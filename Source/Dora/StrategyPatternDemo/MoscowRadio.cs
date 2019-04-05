namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class MoscowRadio : RussianRadio
    {
        public MoscowRadio(ITransmitBehavior transmitBehavior) : base(transmitBehavior)
        {
        }
    }
}