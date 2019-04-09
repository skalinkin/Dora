namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class IrmoRadio : ConventionalRadio
    {
        public IrmoRadio(ITransmitBehavior transmitBehavior) : base(transmitBehavior)
        {
        }
    }
}