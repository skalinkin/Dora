namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class ConventionalRadio : Radio
    {
        internal override void InternalTransmitData(ITransmitReceiver output)
        {
            output.TransmitData("-");
        }
    }
}