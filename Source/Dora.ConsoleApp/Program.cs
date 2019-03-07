using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = CommandLine.Parser.Default.ParseArguments<ShowOption>(args);
        }
    }
}
