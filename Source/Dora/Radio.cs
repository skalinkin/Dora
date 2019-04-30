using System.Collections.Generic;

namespace Avtec.DevMorningFix.Dora
{
    public class Radio : IMonitoringSubject
    {
        private readonly List<IMonitoringObserver> _observers = new List<IMonitoringObserver>();
        protected ITransmitBehavior TransmitBehavior;

        protected Radio(ITransmitBehavior transmitBehavior)
        {
            TransmitBehavior = transmitBehavior;
        }

        public void Attach(IMonitoringObserver observer)
        {
            observer.SetSubject(this);
            _observers.Add(observer);
        }

        public void Detach(IMonitoringObserver observer)
        {
            observer.SetSubject(null);
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }

        public string SubjectState { get; protected set; }

        public void Transmit(ITransmitReceiver output)
        {
            SubjectState = "On Air";
            Notify();
            TransmitBehavior.Transmit(output);
            SubjectState = "Idle";
            Notify();
        }
    }
}