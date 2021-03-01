using _1Time.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Time.Views
{
    public partial class SettingPopup : Form
    {
        private TimerSetting _setting;

        public SettingPopup()
        {
            _setting = new TimerSetting(AppSettings.Instance.TimerSetting);
            InitializeComponent();
            ApplySettingToView();
        }

        private void ApplySettingToView()
        {
            radioAlarmMode.Checked = (_setting.Mode == TimerType.Alarm);
            radioCountDownMode.Checked = (_setting.Mode == TimerType.CountDown);
            numericUpDownHours.Value = _setting.Hours;
            numericUpDownMinutes.Value = _setting.Minutes;
            numericUpDownSeconds.Value = _setting.Seconds;
            checkUseRepeat.Checked = _setting.UseRepeat;
            dateTimePickerAlarmTime.Value = new DateTime(_setting.AlarmTime);
            checkUsePlaySoundOrMedia.Checked = _setting.UsePlaySoundOrMedia;
            radioBeep.Checked = (_setting.SoundMode == SoundType.Beep);
            radioPlayFile.Checked = (_setting.SoundMode == SoundType.MusicFile);
            textBoxMusicFilePath.Text = _setting.MusicFilePath;
        }

        private void ApplyViewToSetting()
        {
            _setting.Mode = radioAlarmMode.Checked ? TimerType.Alarm : TimerType.CountDown;
            _setting.Hours = (int)numericUpDownHours.Value;
            _setting.Minutes = (int)numericUpDownMinutes.Value;
            _setting.Seconds = (int)numericUpDownSeconds.Value;
            _setting.UseRepeat = checkUseRepeat.Checked;
            _setting.AlarmTime = dateTimePickerAlarmTime.Value.Ticks;
            _setting.UsePlaySoundOrMedia = checkUsePlaySoundOrMedia.Checked;
            _setting.SoundMode = radioBeep.Checked ? SoundType.Beep : SoundType.MusicFile;
            _setting.MusicFilePath = textBoxMusicFilePath.Text;
        }

        private void RefreshEnables()
        {
            numericUpDownHours.Enabled = numericUpDownMinutes.Enabled = numericUpDownSeconds.Enabled = checkUseRepeat.Enabled = (_setting.Mode == TimerType.CountDown);
            dateTimePickerAlarmTime.Enabled = (_setting.Mode == TimerType.Alarm);
            radioBeep.Enabled = radioPlayFile.Enabled = _setting.UsePlaySoundOrMedia;
            textBoxMusicFilePath.Enabled = buttonBrowse.Enabled = (_setting.UsePlaySoundOrMedia && _setting.SoundMode == SoundType.MusicFile);
        }

        private void SettingValue_Changed(object sender, EventArgs e)
        {
            ApplyViewToSetting();
            RefreshEnables();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMusicFilePath.Text = dialog.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            AppSettings.Instance.TimerSetting = _setting;
            AppSettings.Instance.Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
