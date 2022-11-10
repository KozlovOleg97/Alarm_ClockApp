using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_ClockApp
{
    internal interface IAlarm_Clock
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
