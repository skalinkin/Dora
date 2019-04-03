namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class OruamKcinRadio : ConventionalRadio
    {
        public new void Transmit(ITransmitReceiver output) {
            output.TransmitData("+");
            base.Transmit(output);
        }
        internal override void InternalTransmitData(ITransmitReceiver output)
        {
        }
    }
}
