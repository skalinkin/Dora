namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class AnalogRadio : Radio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("pshhh pshhh phsss");
        }
    }
}