using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_ClockApp
{
    internal sealed class AlarmClock
    {
        public event EventHandler eventHandler;

        
        private static AlarmClock? timer;

        public static AlarmClock? Timer
        {
            get { return timer; }
            set =>
                timer = value;
        }

    }


}


    

