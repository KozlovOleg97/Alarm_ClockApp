using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_ClockApp
{
    internal interface IObserver
    {
        void Update(IAlarm_Clock alarm_Clock);
    }
}
