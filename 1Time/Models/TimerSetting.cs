using _1Time.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Time.Models
{
    public class TimerSetting
    {
        public TimerSetting()
        {
        }

        public TimerSetting(TimerSetting setting)
        {
            this.Mode = setting.Mode;
            this.Hours = setting.Hours;
            this.Minutes = setting.Minutes;
            this.Seconds = setting.Seconds;
            this.UseRepeat = setting.UseRepeat;
            this.AlarmTime = setting.AlarmTime;
            this.UsePlaySoundOrMedia = setting.UsePlaySoundOrMedia;
            this.SoundMode = setting.SoundMode;
            this.MusicFilePath = setting.MusicFilePath;
        }

        public TimerType Mode { get; set; } = TimerType.CountDown;
        
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public bool UseRepeat { get; set; } = true;

        public long AlarmTime { get; set; } = DateTime.Today.Ticks;
            
        public bool UsePlaySoundOrMedia { get; set; }

        public SoundType SoundMode { get; set; } = SoundType.Beep;

        public string MusicFilePath { get; set; }
    }
}
