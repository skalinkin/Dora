﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    class BrokenLspRadio:OruamKcinRadio
    {
        public BrokenLspRadio(ITransmitBehavior transmitBehavior) :base(transmitBehavior)
        {
        } 
    }
}
