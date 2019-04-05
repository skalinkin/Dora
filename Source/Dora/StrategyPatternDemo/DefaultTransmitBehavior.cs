namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class DefaultTransmitBehavior : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Begin Transmitting");
            output.TransmitData("End Transmitting");
            output.TransmitData("..");
        }
    }
}