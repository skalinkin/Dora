using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    class SgnirtsSdrawkcabBehavior : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Gnirts Sdrawkcab");
        }
    }
}
