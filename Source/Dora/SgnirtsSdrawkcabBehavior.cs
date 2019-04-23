namespace Avtec.DevMorningFix.Dora
{
    class SgnirtsSdrawkcabBehavior : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Gnirts Sdrawkcab");
        }
    }
}
