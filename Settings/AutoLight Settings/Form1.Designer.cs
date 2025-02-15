namespace AutoLight_Settings
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            lightAmPmDomainUpDown = new DomainUpDown();
            darkAmPmDomainUpDown = new DomainUpDown();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            darkMinNumericUpDown = new NumericUpDown();
            darkHourNumericUpDown = new NumericUpDown();
            lightMinNumericUpDown = new NumericUpDown();
            lightHourNumericUpDown = new NumericUpDown();
            panel2 = new Panel();
            darkWallpaperFilePathTextBox = new TextBox();
            useWallpaperCheckBox = new CheckBox();
            label5 = new Label();
            lightWallpaperFileButton = new Button();
            label6 = new Label();
            lightWallpaperFilePathTextBox = new TextBox();
            darkWallpaperFileButton = new Button();
            panel3 = new Panel();
            label7 = new Label();
            changeThemeExitDomainUpDown = new DomainUpDown();
            changeThemeExitCheckBox = new CheckBox();
            panel4 = new Panel();
            poolingRateNumericUpDown = new NumericUpDown();
            label8 = new Label();
            notifyThemeChangeCheckBox = new CheckBox();
            notifyCancelExitCheckBox = new CheckBox();
            notifyExitCheckBox = new CheckBox();
            crossesMidnightCheckBox = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)darkMinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)darkHourNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightMinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightHourNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poolingRateNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Switch To Light Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 4);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 0;
            label2.Text = ":";
            // 
            // lightAmPmDomainUpDown
            // 
            lightAmPmDomainUpDown.Items.Add("AM");
            lightAmPmDomainUpDown.Items.Add("PM");
            lightAmPmDomainUpDown.Location = new Point(222, 2);
            lightAmPmDomainUpDown.Name = "lightAmPmDomainUpDown";
            lightAmPmDomainUpDown.ReadOnly = true;
            lightAmPmDomainUpDown.Size = new Size(47, 23);
            lightAmPmDomainUpDown.TabIndex = 2;
            lightAmPmDomainUpDown.Text = "AM";
            lightAmPmDomainUpDown.Wrap = true;
            // 
            // darkAmPmDomainUpDown
            // 
            darkAmPmDomainUpDown.Items.Add("AM");
            darkAmPmDomainUpDown.Items.Add("PM");
            darkAmPmDomainUpDown.Location = new Point(222, 31);
            darkAmPmDomainUpDown.Name = "darkAmPmDomainUpDown";
            darkAmPmDomainUpDown.ReadOnly = true;
            darkAmPmDomainUpDown.Size = new Size(47, 23);
            darkAmPmDomainUpDown.TabIndex = 5;
            darkAmPmDomainUpDown.Text = "AM";
            darkAmPmDomainUpDown.Wrap = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 4;
            label3.Text = "Switch To Dark Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(167, 33);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(crossesMidnightCheckBox);
            panel1.Controls.Add(darkMinNumericUpDown);
            panel1.Controls.Add(darkAmPmDomainUpDown);
            panel1.Controls.Add(darkHourNumericUpDown);
            panel1.Controls.Add(lightMinNumericUpDown);
            panel1.Controls.Add(lightHourNumericUpDown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lightAmPmDomainUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 75);
            panel1.TabIndex = 9;
            // 
            // darkMinNumericUpDown
            // 
            darkMinNumericUpDown.Location = new Point(183, 31);
            darkMinNumericUpDown.Name = "darkMinNumericUpDown";
            darkMinNumericUpDown.Size = new Size(33, 23);
            darkMinNumericUpDown.TabIndex = 4;
            darkMinNumericUpDown.Value = new decimal(new int[] { 59, 0, 0, 0 });
            // 
            // darkHourNumericUpDown
            // 
            darkHourNumericUpDown.Location = new Point(128, 31);
            darkHourNumericUpDown.Name = "darkHourNumericUpDown";
            darkHourNumericUpDown.Size = new Size(33, 23);
            darkHourNumericUpDown.TabIndex = 3;
            darkHourNumericUpDown.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // lightMinNumericUpDown
            // 
            lightMinNumericUpDown.Location = new Point(182, 2);
            lightMinNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            lightMinNumericUpDown.Name = "lightMinNumericUpDown";
            lightMinNumericUpDown.Size = new Size(33, 23);
            lightMinNumericUpDown.TabIndex = 1;
            lightMinNumericUpDown.Value = new decimal(new int[] { 59, 0, 0, 0 });
            // 
            // lightHourNumericUpDown
            // 
            lightHourNumericUpDown.Location = new Point(128, 2);
            lightHourNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            lightHourNumericUpDown.Name = "lightHourNumericUpDown";
            lightHourNumericUpDown.Size = new Size(33, 23);
            lightHourNumericUpDown.TabIndex = 0;
            lightHourNumericUpDown.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(darkWallpaperFilePathTextBox);
            panel2.Controls.Add(useWallpaperCheckBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lightWallpaperFileButton);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lightWallpaperFilePathTextBox);
            panel2.Controls.Add(darkWallpaperFileButton);
            panel2.Location = new Point(12, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 135);
            panel2.TabIndex = 10;
            // 
            // darkWallpaperFilePathTextBox
            // 
            darkWallpaperFilePathTextBox.BackColor = SystemColors.Window;
            darkWallpaperFilePathTextBox.Location = new Point(2, 108);
            darkWallpaperFilePathTextBox.Name = "darkWallpaperFilePathTextBox";
            darkWallpaperFilePathTextBox.Size = new Size(267, 23);
            darkWallpaperFilePathTextBox.TabIndex = 10;
            // 
            // useWallpaperCheckBox
            // 
            useWallpaperCheckBox.AutoSize = true;
            useWallpaperCheckBox.ForeColor = Color.White;
            useWallpaperCheckBox.Location = new Point(3, 3);
            useWallpaperCheckBox.Name = "useWallpaperCheckBox";
            useWallpaperCheckBox.Size = new Size(232, 19);
            useWallpaperCheckBox.TabIndex = 6;
            useWallpaperCheckBox.Text = "Switch Wallpaper Upon Theme Change";
            useWallpaperCheckBox.UseVisualStyleBackColor = true;
            useWallpaperCheckBox.CheckedChanged += useWallpaperCheckBox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 25);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 1;
            label5.Text = "Light Wallpaper:";
            // 
            // lightWallpaperFileButton
            // 
            lightWallpaperFileButton.BackColor = Color.Transparent;
            lightWallpaperFileButton.Location = new Point(194, 21);
            lightWallpaperFileButton.Name = "lightWallpaperFileButton";
            lightWallpaperFileButton.Size = new Size(75, 23);
            lightWallpaperFileButton.TabIndex = 7;
            lightWallpaperFileButton.Text = "Select File";
            lightWallpaperFileButton.UseVisualStyleBackColor = false;
            lightWallpaperFileButton.Click += lightWallpaperFileButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 83);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 12;
            label6.Text = "Dark Wallpaper:";
            // 
            // lightWallpaperFilePathTextBox
            // 
            lightWallpaperFilePathTextBox.BackColor = SystemColors.Window;
            lightWallpaperFilePathTextBox.Location = new Point(2, 50);
            lightWallpaperFilePathTextBox.Name = "lightWallpaperFilePathTextBox";
            lightWallpaperFilePathTextBox.Size = new Size(267, 23);
            lightWallpaperFilePathTextBox.TabIndex = 8;
            // 
            // darkWallpaperFileButton
            // 
            darkWallpaperFileButton.BackColor = Color.Transparent;
            darkWallpaperFileButton.Location = new Point(194, 79);
            darkWallpaperFileButton.Name = "darkWallpaperFileButton";
            darkWallpaperFileButton.Size = new Size(75, 23);
            darkWallpaperFileButton.TabIndex = 9;
            darkWallpaperFileButton.Text = "Select File";
            darkWallpaperFileButton.UseVisualStyleBackColor = false;
            darkWallpaperFileButton.Click += darkWallpaperFileButton_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(changeThemeExitDomainUpDown);
            panel3.Controls.Add(changeThemeExitCheckBox);
            panel3.Location = new Point(12, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 55);
            panel3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 30);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 17;
            label7.Text = "Theme:";
            // 
            // changeThemeExitDomainUpDown
            // 
            changeThemeExitDomainUpDown.Items.Add("Light");
            changeThemeExitDomainUpDown.Items.Add("Dark");
            changeThemeExitDomainUpDown.Location = new Point(55, 28);
            changeThemeExitDomainUpDown.Name = "changeThemeExitDomainUpDown";
            changeThemeExitDomainUpDown.ReadOnly = true;
            changeThemeExitDomainUpDown.Size = new Size(47, 23);
            changeThemeExitDomainUpDown.TabIndex = 12;
            changeThemeExitDomainUpDown.Text = "Light";
            changeThemeExitDomainUpDown.Wrap = true;
            // 
            // changeThemeExitCheckBox
            // 
            changeThemeExitCheckBox.AutoSize = true;
            changeThemeExitCheckBox.ForeColor = Color.White;
            changeThemeExitCheckBox.Location = new Point(3, 3);
            changeThemeExitCheckBox.Name = "changeThemeExitCheckBox";
            changeThemeExitCheckBox.Size = new Size(147, 19);
            changeThemeExitCheckBox.TabIndex = 11;
            changeThemeExitCheckBox.Text = "Change Theme On Exit";
            changeThemeExitCheckBox.UseVisualStyleBackColor = true;
            changeThemeExitCheckBox.CheckedChanged += changeThemeExitCheckBox_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(poolingRateNumericUpDown);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(notifyThemeChangeCheckBox);
            panel4.Controls.Add(notifyCancelExitCheckBox);
            panel4.Controls.Add(notifyExitCheckBox);
            panel4.Location = new Point(12, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 105);
            panel4.TabIndex = 18;
            // 
            // poolingRateNumericUpDown
            // 
            poolingRateNumericUpDown.Location = new Point(146, 78);
            poolingRateNumericUpDown.Name = "poolingRateNumericUpDown";
            poolingRateNumericUpDown.Size = new Size(123, 23);
            poolingRateNumericUpDown.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 80);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 18;
            label8.Text = "Pooling Rate In Seconds:";
            // 
            // notifyThemeChangeCheckBox
            // 
            notifyThemeChangeCheckBox.AutoSize = true;
            notifyThemeChangeCheckBox.ForeColor = Color.White;
            notifyThemeChangeCheckBox.Location = new Point(3, 53);
            notifyThemeChangeCheckBox.Name = "notifyThemeChangeCheckBox";
            notifyThemeChangeCheckBox.Size = new Size(174, 19);
            notifyThemeChangeCheckBox.TabIndex = 15;
            notifyThemeChangeCheckBox.Text = "Notify Upon Theme Change";
            notifyThemeChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // notifyCancelExitCheckBox
            // 
            notifyCancelExitCheckBox.AutoSize = true;
            notifyCancelExitCheckBox.ForeColor = Color.White;
            notifyCancelExitCheckBox.Location = new Point(3, 28);
            notifyCancelExitCheckBox.Name = "notifyCancelExitCheckBox";
            notifyCancelExitCheckBox.Size = new Size(152, 19);
            notifyCancelExitCheckBox.TabIndex = 14;
            notifyCancelExitCheckBox.Text = "Notify Upon Cancel Exit";
            notifyCancelExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // notifyExitCheckBox
            // 
            notifyExitCheckBox.AutoSize = true;
            notifyExitCheckBox.ForeColor = Color.White;
            notifyExitCheckBox.Location = new Point(3, 3);
            notifyExitCheckBox.Name = "notifyExitCheckBox";
            notifyExitCheckBox.Size = new Size(113, 19);
            notifyExitCheckBox.TabIndex = 13;
            notifyExitCheckBox.Text = "Notify Upon Exit";
            notifyExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // crossesMidnightCheckBox
            // 
            crossesMidnightCheckBox.AutoSize = true;
            crossesMidnightCheckBox.ForeColor = Color.White;
            crossesMidnightCheckBox.Location = new Point(3, 51);
            crossesMidnightCheckBox.Name = "crossesMidnightCheckBox";
            crossesMidnightCheckBox.Size = new Size(118, 19);
            crossesMidnightCheckBox.TabIndex = 6;
            crossesMidnightCheckBox.Text = "Crosses Midnight";
            crossesMidnightCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 16);
            ClientSize = new Size(297, 410);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Autolight Settings";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)darkMinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)darkHourNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightMinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightHourNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)poolingRateNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DomainUpDown lightAmPmDomainUpDown;
        private DomainUpDown darkAmPmDomainUpDown;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private CheckBox useWallpaperCheckBox;
        private Button lightWallpaperFileButton;
        private TextBox lightWallpaperFilePathTextBox;
        private Label label5;
        private TextBox darkWallpaperFilePathTextBox;
        private Button darkWallpaperFileButton;
        private Label label6;
        private Panel panel3;
        private CheckBox changeThemeExitCheckBox;
        private Label label7;
        private DomainUpDown changeThemeExitDomainUpDown;
        private Panel panel4;
        private Label label8;
        private CheckBox notifyThemeChangeCheckBox;
        private CheckBox notifyCancelExitCheckBox;
        private CheckBox notifyExitCheckBox;
        private NumericUpDown poolingRateNumericUpDown;
        private NumericUpDown darkMinNumericUpDown;
        private NumericUpDown darkHourNumericUpDown;
        private NumericUpDown lightMinNumericUpDown;
        private NumericUpDown lightHourNumericUpDown;
        private CheckBox crossesMidnightCheckBox;
    }
}
