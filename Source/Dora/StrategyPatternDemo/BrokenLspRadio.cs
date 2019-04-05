namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class BrokenLspRadio : OruamKcinRadio
    {
        public BrokenLspRadio(ITransmitBehavior transmitBehavior) : base(transmitBehavior)
        {
        }
    }
}