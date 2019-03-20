namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public abstract class Radio
    {
        public virtual void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("I am just a radio");
        }
    }
}