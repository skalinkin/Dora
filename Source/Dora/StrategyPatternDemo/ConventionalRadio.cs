namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class ConventionalRadio : Radio
    {
        public ConventionalRadio(ITransmitBehavior transmitBehavior) : base(transmitBehavior)
        {
        }
    }
}