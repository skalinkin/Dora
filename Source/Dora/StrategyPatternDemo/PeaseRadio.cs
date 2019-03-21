namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class PeaseRadio : Radio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Pease Pourage Hot, Pease  pourage cold");
        }
    }
}