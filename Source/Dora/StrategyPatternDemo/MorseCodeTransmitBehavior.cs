using System;

namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class MorseCodeTransmitBehavior : ITransmitBehavior
    {
            public void Transmit(ITransmitReceiver output)
            {
                output.TransmitData("...");
                output.TransmitData("---");
                output.TransmitData("...");
            }
        
    }
}