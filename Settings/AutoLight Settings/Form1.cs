using System.Globalization;
using System.IO;
using System.Text.Json;

namespace AutoLight_Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Select(); // select the form instead of the first textbox
            FormClosing += Form1_FormClosing;

        }

        private bool settingsExists;
        private string settingsPath = string.Empty;
        private ProgramSettings settings = new();

        private (int, int) Convert24HrTo12(int hour)
        {
            if (hour > 12)
            {
                return (hour - 12, 1); // 1=pm
            }
            else
            {
                return (hour, 0); // 0=am
            }

        }
        private void FillSettingsClass()
        {
            if (lightAmPmDomainUpDown.SelectedIndex == 1) // PM
            {
                settings.SwitchLightHour = (int)lightHourNumericUpDown.Value + 12;
            }
            else
            {
                settings.SwitchLightHour = (int)lightHourNumericUpDown.Value;
            }
            if (darkAmPmDomainUpDown.SelectedIndex == 1) // PM
            {
                settings.SwitchDarkHour = (int)darkHourNumericUpDown.Value + 12;
            }
            else
            {
                settings.SwitchDarkHour = (int)darkHourNumericUpDown.Value;
            }
            settings.CrossesMidnight = crossesMidnightCheckBox.Checked;
            settings.SwitchLightMinute = (int)lightMinNumericUpDown.Value;
            settings.SwitchDarkMinute = (int)darkMinNumericUpDown.Value;
            settings.LightBgPath = lightWallpaperFilePathTextBox.Text;
            settings.DarkBgPath = darkWallpaperFilePathTextBox.Text;
            settings.PoolingRate = (int)poolingRateNumericUpDown.Value;
            settings.ExitTheme = (string)changeThemeExitDomainUpDown.SelectedItem;
            settings.UseWallpaper = useWallpaperCheckBox.Checked;
            settings.UseExitTheme = changeThemeExitCheckBox.Checked;
            settings.NotifyUponExit = notifyExitCheckBox.Checked;
            settings.NotifyUponExitCancel = notifyCancelExitCheckBox.Checked;
            settings.NotifyUponSwitch = notifyThemeChangeCheckBox.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initalize default values in the case of no settings file
            lightAmPmDomainUpDown.SelectedIndex = 0;
            darkAmPmDomainUpDown.SelectedIndex = 0;

            lightWallpaperFileButton.Enabled = false;
            darkWallpaperFileButton.Enabled = false;
            lightWallpaperFilePathTextBox.Enabled = false;
            darkWallpaperFilePathTextBox.Enabled = false;

            changeThemeExitDomainUpDown.Enabled = false;

            // load settings if it exists
            string[] args = Environment.GetCommandLineArgs();
            int settingsIndex = Array.IndexOf(args, "-settings");

            if (settingsIndex != -1)
            {
                settingsPath = args[settingsIndex + 1];
                settingsExists = true;
            }
            else // file was not passed, check for file occurance in runtime path
            {
                if (File.Exists("settings.json")) // file was found!
                {
                    settingsExists = true;
                    settingsPath = "settings.json";
                }
                else // file does not exist
                {
                    settingsExists = false;
                    MessageBox.Show("Settings file was not passed as an argument.\nYou will be asked to save upon exit.");
                }
            }

            if (settingsExists) // serialize values into settings class and populate values
            {
                // serialize
                string json = File.ReadAllText(settingsPath);
                settings = JsonSerializer.Deserialize<ProgramSettings>(json);

                if (settings == null)
                {
                    MessageBox.Show("Corrupt settings file.");
                    return;
                }

                // populate values

                (int, int) convertedLightHour = Convert24HrTo12(settings.SwitchLightHour);
                (int, int) convertedDarkHour = Convert24HrTo12(settings.SwitchDarkHour);

                lightHourNumericUpDown.Value = convertedLightHour.Item1;
                lightMinNumericUpDown.Value = settings.SwitchLightMinute;
                darkHourNumericUpDown.Value = convertedDarkHour.Item1;
                darkMinNumericUpDown.Value = settings.SwitchDarkMinute;
                crossesMidnightCheckBox.Checked = settings.CrossesMidnight;
                lightAmPmDomainUpDown.SelectedIndex = convertedLightHour.Item2;
                darkAmPmDomainUpDown.SelectedIndex = convertedDarkHour.Item2;


                useWallpaperCheckBox.Checked = settings.UseWallpaper;
                lightWallpaperFilePathTextBox.Text = settings.LightBgPath;
                darkWallpaperFilePathTextBox.Text = settings.DarkBgPath;

                changeThemeExitCheckBox.Checked = settings.UseExitTheme;
                switch (settings.ExitTheme) // exit theme dropdown
                {
                    case "Light":
                        changeThemeExitDomainUpDown.SelectedIndex = 0; break;
                    case "Dark":
                        changeThemeExitDomainUpDown.SelectedIndex = 1; break;
                }

                notifyExitCheckBox.Checked = settings.NotifyUponExit;
                notifyCancelExitCheckBox.Checked = settings.NotifyUponExitCancel;
                notifyThemeChangeCheckBox.Checked = settings.NotifyUponSwitch;
                poolingRateNumericUpDown.Value = settings.PoolingRate;
            }
        }
        private void lightWallpaperFileButton_Click(object sender, EventArgs e) // show dialog to select a file
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    lightWallpaperFilePathTextBox.Text = openFileDialog1.FileName;
                }
            }
        }
        private void darkWallpaperFileButton_Click(object sender, EventArgs e) // show dialog to select a file
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    darkWallpaperFilePathTextBox.Text = openFileDialog1.FileName;
                }
            }
        }
        private void useWallpaperCheckBox_CheckedChanged(object sender, EventArgs e) // disables elements based on if checkbox is checked
        {
            lightWallpaperFileButton.Enabled = useWallpaperCheckBox.Checked;
            darkWallpaperFileButton.Enabled = useWallpaperCheckBox.Checked;
            lightWallpaperFilePathTextBox.Enabled = useWallpaperCheckBox.Checked;
            darkWallpaperFilePathTextBox.Enabled = useWallpaperCheckBox.Checked;
        }
        private void changeThemeExitCheckBox_CheckedChanged(object sender, EventArgs e) // disables elements based on if checkbox is checked
        {
            changeThemeExitDomainUpDown.Enabled = changeThemeExitCheckBox.Checked;
        }
        private void Form1_FormClosing(object sender, EventArgs e) // save and quit
        {
            FillSettingsClass();
            // serialize and write json
            string serializedString = JsonSerializer.Serialize(settings);
            if (settingsExists)
            {
                File.WriteAllText(settingsPath, serializedString);
            }
            else // settings file was not found on startup, save settings file manually
            {
                MessageBox.Show("Please save your settings file.");

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json files (*.json)|";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        File.WriteAllText(saveFileDialog1.FileName, serializedString);
                    }
                }
            }
        }


    }

    public class ProgramSettings // class for json serialization, default vals are in case of no settings file
    { // why do i have to be down here mr winforms designer :(
        public int SwitchDarkHour { get; set; } = 23;
        public int SwitchDarkMinute { get; set; } = 59;
        public int SwitchLightHour { get; set; } = 23;
        public int SwitchLightMinute { get; set; } = 59;
        public bool CrossesMidnight { get; set; } = false;
        public string LightBgPath { get; set; } = string.Empty;
        public string DarkBgPath { get; set; } = string.Empty;
        public int PoolingRate { get; set; } = 2;
        public string ExitTheme { get; set; } = string.Empty ;
        public bool UseWallpaper { get; set; } = false;
        public bool UseExitTheme { get; set; } = false;
        public bool NotifyUponExit { get; set; } = false;
        public bool NotifyUponExitCancel { get; set; } = false;
        public bool NotifyUponSwitch { get; set; } = false;
    }
}
