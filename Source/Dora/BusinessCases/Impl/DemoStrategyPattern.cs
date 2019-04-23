using System.Collections.Generic;

namespace Avtec.DevMorningFix.Dora.BusinessCases.Impl
{
    internal class DemoStrategyPattern : IDemoStrategyPattern
    {
        private readonly ITransmitReceiver _output;
        private readonly IEnumerable<Radio> _radios;

        public DemoStrategyPattern(IEnumerable<Radio> radios, ITransmitReceiver output)
        {
            _radios = radios;
            _output = output;
        }

        public void Execute()
        {
            foreach (var radio in _radios)
            {
                radio.Transmit(_output);
            }
        }
    }
}