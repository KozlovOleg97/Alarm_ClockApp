using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_ClockApp
{
    internal sealed class Observer : IAlarm_Clock
    {
        public int State { get; set; } = -0;
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine();
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine();
        }

        public void Notify()
        {
            Console.WriteLine();

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
