namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class OruamKcinRadio : AnalogRadio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Lift heavy, eat tacos.");
        }
    }
}
