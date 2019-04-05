using System.Collections.Generic;

namespace Avtec.DevMorningFix.Dora
{
    public interface IShowTheListOfFundamentals
    {
        IEnumerable<IAvtecEngineeringFundamental> Result { get; }
        void Execute();
    }
}