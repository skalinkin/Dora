namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class RussianRadio : PeaseRadio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Raz.. Dva.. Tri.. Do you copy?");
        }
    }
}