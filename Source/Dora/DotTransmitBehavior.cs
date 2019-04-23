namespace Avtec.DevMorningFix.Dora
{
    internal class DotTransmitBehavior : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Begin Transmitting");
            output.TransmitData("End Transmitting");
            output.TransmitData(".");
        }
    }
}