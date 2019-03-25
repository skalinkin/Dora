﻿namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class SimplexRadio : Radio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            base.Transmit(output);
            output.TransmitData("but I cannot transmit while receiving");
        }
    }
}