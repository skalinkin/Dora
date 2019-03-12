using System;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal class ShowCommand : IShowCommand
    {
        private readonly IShowTheListOfFundamentals _businessCase;
        private readonly IFundamentalFormatter _formatter;

        public ShowCommand(IShowTheListOfFundamentals businessCase, IFundamentalFormatter formatter)
        {
            _businessCase = businessCase;
            _formatter = formatter;
        }
        public void Execute(ShowOption showOption)
        {
           _businessCase.Execute();
           foreach (var fundamental in _businessCase.Result)
           {
               var text = _formatter.GetFormattedString(fundamental);
               Console.WriteLine(text);
           }
        }
    }
}