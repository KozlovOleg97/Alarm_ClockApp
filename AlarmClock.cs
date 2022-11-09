using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_ClockApp
{
    internal sealed class AlarmClock
    {
        public EventHandler countdownEvent;

        public void SignUpEventHandler(AlarmClock alarmClock)
        {
            alarmClock.countdownEvent
        }
    }
}
