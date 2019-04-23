namespace Avtec.DevMorningFix.Dora
{
    public interface ITransmitBehavior
    {
        void Transmit(ITransmitReceiver output);
    }
}