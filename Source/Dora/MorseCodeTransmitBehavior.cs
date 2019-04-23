namespace Avtec.DevMorningFix.Dora
{
    internal class MorseCodeTransmitBehavior : ITransmitBehavior
    {
            public void Transmit(ITransmitReceiver output)
            {
                output.TransmitData("...");
                output.TransmitData("---");
                output.TransmitData("...");
            }
        
    }
}