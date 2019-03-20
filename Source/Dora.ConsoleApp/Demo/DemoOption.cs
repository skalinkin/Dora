using System;
using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    [Verb("demo", HelpText = "Demonstrate application of a pattern")]
    internal class DemoOption:IOption
    {
        [Option('p',"pattern",Required = true)]
        public Demos Pattern { get; set; }

        public Type GetCommandType()
        {
            return typeof(DemoCommand);
        }
    }
}