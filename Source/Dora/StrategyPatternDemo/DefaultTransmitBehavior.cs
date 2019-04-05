﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    class DefaultTransmitBehavior : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Begin Tramsmitting");
            output.TransmitData($"Name:{GetType().Name}");
            output.TransmitData("End Transmitting");
            output.TransmitData("..");
        }
    }
}
