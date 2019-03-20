namespace Avtec.DevMorningFix.Dora.StrategyPatternDemo
{
    public class ConventionalRadio : Radio
    {
        public override void Transmit(ITransmitReceiver output)
        {
            base.Transmit(output);
            output.TransmitData("but conventional");
        }
    }
}