namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public abstract class Radio
    {
        public void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Begin Tramsmitting");
            output.TransmitData($"Name:{GetType().Name}");
            InternalTransmitData(output);
            output.TransmitData("End Transmitting");
            if(this.GetType() != typeof(MoscowRadio))
            {
                output.TransmitData(".");
            }
            if(this.GetType() != typeof(RussianRadio))
            {
                output.TransmitData(".");
            }
        }

        internal abstract void InternalTransmitData(ITransmitReceiver output);
    }
}