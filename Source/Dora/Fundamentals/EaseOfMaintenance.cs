namespace Avtec.DevMorningFix.Dora.Fundamentals
{
    class EaseOfMaintenance : IAvtecEngineeringFundamental
    {
        public string GetName()
        {
            return "Ease of maintenance";
        }

        public string GetDescription()
        {
            return
                @"Ease of maintenance means designing for the maintenance programmer. Continually imagine the questions a maintenance programmer would ask about the code you’re writing. Think of the maintenance programmer as your audience, and then design the system to be self-explanatory";
        }
    }
}