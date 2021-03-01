
namespace _1Time.Views
{
    partial class SettingPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioCountDownMode = new System.Windows.Forms.RadioButton();
            this.radioAlarmMode = new System.Windows.Forms.RadioButton();
            this.checkUseRepeat = new System.Windows.Forms.CheckBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxMusicFilePath = new System.Windows.Forms.TextBox();
            this.radioPlayFile = new System.Windows.Forms.RadioButton();
            this.radioBeep = new System.Windows.Forms.RadioButton();
            this.checkUsePlaySoundOrMedia = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCountDownMode
            // 
            this.radioCountDownMode.AutoSize = true;
            this.radioCountDownMode.Location = new System.Drawing.Point(23, 36);
            this.radioCountDownMode.Name = "radioCountDownMode";
            this.radioCountDownMode.Size = new System.Drawing.Size(124, 17);
            this.radioCountDownMode.TabIndex = 0;
            this.radioCountDownMode.TabStop = true;
            this.radioCountDownMode.Text = "Set Countdown Time";
            this.radioCountDownMode.UseVisualStyleBackColor = true;
            this.radioCountDownMode.CheckedChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // radioAlarmMode
            // 
            this.radioAlarmMode.AutoSize = true;
            this.radioAlarmMode.Location = new System.Drawing.Point(23, 91);
            this.radioAlarmMode.Name = "radioAlarmMode";
            this.radioAlarmMode.Size = new System.Drawing.Size(96, 17);
            this.radioAlarmMode.TabIndex = 1;
            this.radioAlarmMode.TabStop = true;
            this.radioAlarmMode.Text = "Set Alarm Time";
            this.radioAlarmMode.UseVisualStyleBackColor = true;
            this.radioAlarmMode.CheckedChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // checkUseRepeat
            // 
            this.checkUseRepeat.AutoSize = true;
            this.checkUseRepeat.Location = new System.Drawing.Point(47, 59);
            this.checkUseRepeat.Name = "checkUseRepeat";
            this.checkUseRepeat.Size = new System.Drawing.Size(61, 17);
            this.checkUseRepeat.TabIndex = 2;
            this.checkUseRepeat.Text = "Repeat";
            this.checkUseRepeat.UseVisualStyleBackColor = true;
            this.checkUseRepeat.CheckedChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(164, 33);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownHours.TabIndex = 3;
            this.numericUpDownHours.ValueChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(211, 33);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownMinutes.TabIndex = 4;
            this.numericUpDownMinutes.ValueChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(258, 33);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownSeconds.TabIndex = 5;
            this.numericUpDownSeconds.ValueChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seconds";
            // 
            // dateTimePickerAlarmTime
            // 
            this.dateTimePickerAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAlarmTime.Location = new System.Drawing.Point(164, 88);
            this.dateTimePickerAlarmTime.Name = "dateTimePickerAlarmTime";
            this.dateTimePickerAlarmTime.ShowUpDown = true;
            this.dateTimePickerAlarmTime.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerAlarmTime.TabIndex = 9;
            this.dateTimePickerAlarmTime.ValueChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.textBoxMusicFilePath);
            this.groupBox1.Controls.Add(this.radioPlayFile);
            this.groupBox1.Controls.Add(this.radioBeep);
            this.groupBox1.Controls.Add(this.checkUsePlaySoundOrMedia);
            this.groupBox1.Location = new System.Drawing.Point(13, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(264, 56);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxMusicFilePath
            // 
            this.textBoxMusicFilePath.Location = new System.Drawing.Point(89, 58);
            this.textBoxMusicFilePath.Name = "textBoxMusicFilePath";
            this.textBoxMusicFilePath.Size = new System.Drawing.Size(169, 20);
            this.textBoxMusicFilePath.TabIndex = 3;
            this.textBoxMusicFilePath.TextChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // radioPlayFile
            // 
            this.radioPlayFile.AutoSize = true;
            this.radioPlayFile.Location = new System.Drawing.Point(22, 59);
            this.radioPlayFile.Name = "radioPlayFile";
            this.radioPlayFile.Size = new System.Drawing.Size(61, 17);
            this.radioPlayFile.TabIndex = 2;
            this.radioPlayFile.TabStop = true;
            this.radioPlayFile.Text = "Play file";
            this.radioPlayFile.UseVisualStyleBackColor = true;
            this.radioPlayFile.CheckedChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // radioBeep
            // 
            this.radioBeep.AutoSize = true;
            this.radioBeep.Location = new System.Drawing.Point(22, 36);
            this.radioBeep.Name = "radioBeep";
            this.radioBeep.Size = new System.Drawing.Size(50, 17);
            this.radioBeep.TabIndex = 1;
            this.radioBeep.TabStop = true;
            this.radioBeep.Text = "Beep";
            this.radioBeep.UseVisualStyleBackColor = true;
            this.radioBeep.CheckedChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // checkUsePlaySoundOrMedia
            // 
            this.checkUsePlaySoundOrMedia.AutoSize = true;
            this.checkUsePlaySoundOrMedia.Location = new System.Drawing.Point(10, 0);
            this.checkUsePlaySoundOrMedia.Name = "checkUsePlaySoundOrMedia";
            this.checkUsePlaySoundOrMedia.Size = new System.Drawing.Size(124, 17);
            this.checkUsePlaySoundOrMedia.TabIndex = 0;
            this.checkUsePlaySoundOrMedia.Text = "Play Sound or Media";
            this.checkUsePlaySoundOrMedia.UseVisualStyleBackColor = true;
            this.checkUsePlaySoundOrMedia.CheckedChanged += new System.EventHandler(this.SettingValue_Changed);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(36, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(149, 246);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(262, 246);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 13;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // SettingPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 281);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerAlarmTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.checkUseRepeat);
            this.Controls.Add(this.radioAlarmMode);
            this.Controls.Add(this.radioCountDownMode);
            this.Name = "SettingPopup";
            this.Text = "1Time Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCountDownMode;
        private System.Windows.Forms.RadioButton radioAlarmMode;
        private System.Windows.Forms.CheckBox checkUseRepeat;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlarmTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxMusicFilePath;
        private System.Windows.Forms.RadioButton radioPlayFile;
        private System.Windows.Forms.RadioButton radioBeep;
        private System.Windows.Forms.CheckBox checkUsePlaySoundOrMedia;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonHelp;
    }
}