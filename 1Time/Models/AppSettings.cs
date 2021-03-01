using _1Time.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Time.Models
{
    public class AppSettings : Singleton<AppSettings>
    {
        public TimerSetting TimerSetting { get; set; } = new TimerSetting();

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
