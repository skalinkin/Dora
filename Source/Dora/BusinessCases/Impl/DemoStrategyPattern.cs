using System.Collections.Generic;
using Avtec.DevMorningFix.Dora.StrategyPatternDemo;

namespace Avtec.DevMorningFix.Dora.BusinessCases.Impl
{
    internal class DemoStrategyPattern : IDemoStrategyPattern
    {
        private readonly IEnumerable<Radio> _radios;
        private readonly ITransmitReceiver _output;

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