namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public abstract class Radio
    {
        protected ITransmitBehavior _transmitBehavior;
        public Radio(ITransmitBehavior transmitBehavio)
        {
            _transmitBehavior = transmitBehavio;
        }
        public void Transmit(ITransmitReceiver output)
        {
            _transmitBehavior.Transmit(output);
        }
    }
}