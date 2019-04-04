using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public interface ITransmitBehavior
    {
        void Transmit(ITransmitReceiver output);
    }
}
