namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class AnalogRadio : Radio
    {
        internal override void InternalTransmitData(ITransmitReceiver output)
        {
            output.TransmitData("+");
        }
    }
}