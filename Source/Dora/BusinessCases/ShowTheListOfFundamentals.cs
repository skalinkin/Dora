using System.Collections.Generic;
using System.Linq;

namespace Avtec.DevMorningFix.Dora.BusinessCases
{
    public class ShowTheListOfFundamentals : IShowTheListOfFundamentals
    {
        private readonly IEnumerable<IAvtecEngineeringFundamental> _fundamentals;

        public ShowTheListOfFundamentals(IEnumerable<IAvtecEngineeringFundamental> fundamentals)
        {
            _fundamentals = fundamentals;
        }

        public void Execute()
        {
        }

        public IEnumerable<IAvtecEngineeringFundamental> Result => _fundamentals.ToArray();
    }
}