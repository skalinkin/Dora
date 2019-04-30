using System;
using Avtec.DevMorningFix.Dora.BusinessCases;
using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    [Verb("demo", HelpText = "Demonstrate application of a pattern")]
    internal class DemoOption : IOption
    {
        [Option('p', "pattern", Required = true,
            HelpText = "For example, demo -p Strategy or demo --pattern Strategy. The -p value is CaSe sensitive.")]
        public Demos Pattern { get; set; }

        public Type GetCommandType()
        {
            return typeof(DemoCommand);
        }
    }
}