namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public class Radio
    {
        protected ITransmitBehavior TransmitBehavior;

        protected Radio(ITransmitBehavior transmitBehavior)
        {
            TransmitBehavior = transmitBehavior;
        }

        public void Transmit(ITransmitReceiver output)
        {
            TransmitBehavior.Transmit(output);
        }
    }
}