using _1Time.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Time.Models
{
    public class AppSetting : Singleton<AppSetting>
    {
        public TimerType Mode { get; set; } = TimerType.CountDown;
        
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public bool UseRepeat { get; set; } = true;

        public long AlarmTime { get; set; }
        
        public bool UsePlaySoundOrMedia { get; set; }

        public SoundType SoundMode { get; set; } = SoundType.Beep;

        public string MusicFilePath { get; set; }
    }
}
