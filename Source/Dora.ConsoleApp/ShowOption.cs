using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    [Verb("show",HelpText = "Shows name and detail of a Fundamental")]
    class ShowOption
    {
        [Value(0)]
        public string FundamentalName { get; set; }
    }
}
