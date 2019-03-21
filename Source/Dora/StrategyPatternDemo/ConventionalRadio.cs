namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    internal class ConventionalRadio : Radio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            base.Transmit(output);
            output.TransmitData("but conventional");
        }
    }
}