namespace Avtec.DevMorningFix.Dora.Fundamentals
{
    internal class LooseCoupling : IAvtecEngineeringFundamental
    {
        public string GetName()
        {
            return "Loose coupling";
        }

        public string GetDescription()
        {
            return
                @"Loose coupling means designing so that you hold connections among different parts of a program to a minimum. Use the principles of good abstractions in class interfaces, encapsulation, and information hiding to design classes with as few interconnections as possible. Minimal connectedness minimizes work during integration, testing, and maintenance.";
        }
    }
}