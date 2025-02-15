import pystray, json, datetime, os, ctypes, time, subprocess
from psutil import pid_exists
from PIL import Image

"""
TODO
installer
"""

# check client OS

if os.name != 'nt':
    print("This application is only compatible with Windows Systems.")
    exit

# define general functions

def Mbox(title, text, style=0): # message box, defined up here for readSettings()
    return ctypes.windll.user32.MessageBoxW(0, text, title, style)

def terminate(icon): # called when exit is pressed on the trayapp
    global sysTrayTerminated
    result = 0 # if set to 2: cancel the termination (only set to 1 by message box)
    if settings["NotifyUponExit"]: # show messagebox to user
        if settings["UseExitTheme"]: # show custom message if using exit theme
            result = Mbox("AutoLight", f"Goodbye! Before we go, we are going to set your theme to {settings["ExitTheme"]}", 1)
            print(result)
        else: # generic exit message
            result = Mbox("AutoLight", "Goodbye!", 1)
    if result == 2: # cancel the termination of the program if set to 2 by msgbox
        if settings["NotifyUponExitCancel"]:
            Mbox("AutoLight", "Cancelled!")
    else: # terminate the program
        if settings["UseExitTheme"]:
            if settings["ExitTheme"] == "Dark":
                setTheme("Dark")
            elif settings["ExitTheme"] == "Light":
                setTheme("Light")
        if icon != None:
            icon.stop()
        sysTrayTerminated = True

# define settings functions

def openSettings(): # open the external settings app and get it's process id
    global settingsPid
    process = subprocess.Popen("Autolight Settings.exe", shell=False)
    settingsPid = process.pid
    
def readSettings():
    global settings
    with open("settings.json") as file:
        settings = json.loads(file.read())
    # check for errors in vals

    if settings["SwitchLightHour"] > settings["SwitchDarkHour"] and not settings["CrossesMidnight"]: # dark hour is greater than light hour without crossing midnight
        Mbox("AutoLight", "Error in settings file:\nSwitch to light hour must not be greater than Switch to dark hour without crossing midnight.\nWe must now terminate. We will also open settings for you to correct this.")
        openSettings()
        try: #try to run terminate, will error if icon is not defined
            terminate(icon)
        except: # icon is not defined which means systray has not loaded. we can safely exit()
            exit()

        
        

readSettings() # populate settings for other functions

# define general DateTime Functions

def checkTimeStatus(): # ran on startup to determine current cycle
    now = datetime.datetime.now()

    starthr = settings["SwitchDarkHour"]
    stophr = settings["SwitchLightHour"]
    startmin = settings["SwitchDarkMinute"]
    stopmin = settings["SwitchLightMinute"]

    currentHour = now.hour
    currentMinute = now.minute

    crossesmidnight = settings["CrossesMidnight"]

    if crossesmidnight:
        if not ((starthr <= currentHour <= 23) or (1 <= currentHour <= stophr)):
            return "Dark"
    else:
        if not ((1 <= currentHour <= starthr) or (stophr <= currentHour <= 23)):
            return "Dark"
    if currentHour == starthr:
        if currentMinute > startmin:
            return "Dark"
    elif currentHour == stophr:
        if currentMinute < stopmin:
            return "Dark"
    return "Light"

def getSecondsRemaining(target_hour, target_minute): # get seconds until specified minute
    now = datetime.datetime.now()
    target_time = now.replace(hour=target_hour, minute=target_minute, second=0, microsecond=0)

    if target_time <= now: # after midnight
        target_time += datetime.timedelta(days=1)

    until = (target_time - now).total_seconds()
    return until

# define vars

settingsPid = None
sysTrayTerminated = False
darkCmd = ['reg.exe', 'add', 'HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize', '/v', 'AppsUseLightTheme', '/t', 'REG_DWORD', '/d', '0', '/f'] # switch to dark mode command
lightCmd = ['reg.exe', 'add', 'HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize', '/v', 'AppsUseLightTheme', '/t', 'REG_DWORD', '/d', '1', '/f'] # switch to light mode command
currentTimeCycle = checkTimeStatus() # init currentTimeStatus
lightIconImg = Image.open("icons/day.ico")
darkIconImg = Image.open("icons/night.ico")
exitStatus = None

# define systray functions

def isDark(): # checkTimeStatus wrapper for systray
    def inner(item):
        return currentTimeCycle == "Dark"
    return inner
def isLight(): # checkTimeStatus wrapper for systray
    def inner(item):
        return currentTimeCycle == "Light"
    return inner

def forceLight():
    global currentTimeCycle
    currentTimeCycle = "Light"
def forceDark():
    global currentTimeCycle
    currentTimeCycle = "Dark"

# create systray app

if currentTimeCycle == "Light":
    iconImg = lightIconImg
else:
    iconImg = darkIconImg

menuItems = [
        pystray.MenuItem(
            "Switch to light",
            forceLight,
            enabled=isDark(),
            checked=isLight()
        ),
        pystray.MenuItem(
            "Switch to dark",
            forceDark,
            enabled=isLight(),
            checked=isDark()
        ),

        pystray.Menu.SEPARATOR,

        pystray.MenuItem(
            "Settings",
            openSettings
        ),

        pystray.MenuItem(
            "Exit",
            lambda: terminate(icon)
        )
]

icon = pystray.Icon(
    "AutoLight",
    icon=iconImg,
    menu=pystray.Menu(
        lambda: menuItems
    )
)

icon.run_detached()

# define theme functions

def toggleTimeCycle():
    global currentTimeCycle
    if currentTimeCycle == "Light":
        currentTimeCycle = "Dark"
    else:
        currentTimeCycle = "Light" 

def setTheme(Theme):
    global currentTimeCycle, icon
    if Theme == "Light":
        subprocess.run(lightCmd)
        icon.icon = lightIconImg
    elif Theme == "Dark":
        subprocess.run(darkCmd)
        icon.icon = darkIconImg
    if settings["UseWallpaper"]:
        ctypes.windll.user32.SystemParametersInfoW(20, 0, os.path.abspath(settings[f"{Theme}BgPath"]), 0)
    if settings["NotifyUponSwitch"]:
        icon.notify(f"Theme set to {Theme}", "AutoLight")
    currentTimeCycle = Theme

def waitUntilSwitch():
    global settingsPid
    if currentTimeCycle == "Light":
        switchHour = settings["SwitchLightHour"]
        switchMin = settings["SwitchLightMinute"]
    elif currentTimeCycle == "Dark":
        switchHour = settings["SwitchDarkHour"]
        switchMin = settings["SwitchDarkMinute"]
    oldTimeCycle = currentTimeCycle # used to detect change in currentTimeCycle
    secondsUntilSwitch = getSecondsRemaining(switchHour, switchMin)
    while secondsUntilSwitch > 0:
        secondsUntilSwitch -= settings["PoolingRate"]
        time.sleep(settings["PoolingRate"])
        if settingsPid != None: # settings was opened, waiting for exit
            if not pid_exists(settingsPid): # settings was closed, apply settings and reload
                print("Settings was closed. Reloading!")
                settingsPid = None
                return "Forced"
        if sysTrayTerminated or currentTimeCycle != oldTimeCycle:
            return "Natural"
    if secondsUntilSwitch < 0 or settingsPid != None:\
        return "Forced"

# main loop

while True:
    if currentTimeCycle == "Light":
        if exitStatus != "Forced":
            setTheme("Light")
        exitStatus = waitUntilSwitch()
    else:
        if exitStatus != "Forced":
            setTheme("Dark")
        exitStatus = waitUntilSwitch()
    if sysTrayTerminated:
        quit()    