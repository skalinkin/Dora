namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public abstract class Radio
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Begin Tramsmitting");
            InternalTransmitData(output);
            output.TransmitData("End Transmitting");
        }

        internal abstract void InternalTransmitData(ITransmitReceiver output);
    }
}