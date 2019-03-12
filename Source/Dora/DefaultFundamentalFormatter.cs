namespace Avtec.DevMorningFix.Dora
{
    internal class DefaultFundamentalFormatter : IFundamentalFormatter
    {
        public string GetFormattedString(IAvtecEngineeringFundamental target)
        {
            return $"{target.GetName()}. {target.GetDescription()}.";
        }
    }
}