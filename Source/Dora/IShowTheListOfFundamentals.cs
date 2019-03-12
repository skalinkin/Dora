using System.Collections.Generic;

namespace Avtec.DevMorningFix.Dora
{
    public interface IShowTheListOfFundamentals
    {
        void Execute();
        IEnumerable<IAvtecEngineeringFundamental> Result { get; }
    }
}