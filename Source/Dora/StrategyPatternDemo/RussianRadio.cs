namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class RussianRadio : PeaseRadio
    {
        public RussianRadio(ITransmitBehavior transmitBehavior) : base(transmitBehavior)
        {
        }
    }
}