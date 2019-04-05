namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public interface ITransmitBehavior
    {
        void Transmit(ITransmitReceiver output);
    }
}