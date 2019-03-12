using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    [Verb("show", HelpText = "Shows name and detail of a Fundamental")]
    internal class ShowOption
    {
        [Value(0)] public string FundamentalName { get; set; }
    }
}