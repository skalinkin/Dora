using System;
using System.Collections.Generic;
using System.Linq;

namespace Avtec.DevMorningFix.Dora.BusinessCases.Impl
{
    public class DemoObserverPattern : IDemoPattern
    {
        private readonly ITransmitReceiver _output;
        private readonly IEnumerable<Radio> _radios;
        private readonly IMonitoringObserver _monitor;

        public DemoObserverPattern(ITransmitReceiver output, IEnumerable<Radio> radios, IMonitoringObserver monitor)
        {
            _output = output;
            _radios = radios;
            _monitor = monitor;
        }

        public void Execute()
        {
            _radios.First().Attach(_monitor);

            foreach (var radio in _radios)
            {
                radio.Transmit(_output);
            }
        }
    }
}