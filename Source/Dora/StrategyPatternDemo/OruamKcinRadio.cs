namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class OruamKcinRadio : ConventionalRadio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            output.TransmitData("Lift heavy, eat tacos.");
        }
    }
}
