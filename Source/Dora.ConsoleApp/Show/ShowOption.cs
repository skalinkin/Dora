using System;
using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Show
{
    [Verb("show", HelpText = "Shows name and detail of a Fundamental")]
    internal class ShowOption : IOption
    {
        [Value(0)] public string FundamentalName { get; set; }

        public Type GetCommandType()
        {
            return typeof(ShowCommand);
        }
    }
}