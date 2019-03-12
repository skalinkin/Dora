using System.Collections.Generic;
using System.Diagnostics;
using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal class DoraArgumentsProcessor : IProcessor
    {
        private readonly IShowCommand _command;

        public DoraArgumentsProcessor(IShowCommand command)
        {
            _command = command;
        }
        public void Parse(string[] args)
        {
            var result = Parser.Default.ParseArguments<ShowOption>(args);
            result.WithParsed(WithParsedAction);
            result.WithNotParsed(HandleParseError);
        }

        private void HandleParseError(IEnumerable<Error> obj)
        {
            foreach (var error in obj)
            {
                Debug.Print($"Error during parsing{error.Tag.ToString()}");
            }
            throw new System.InvalidOperationException();
        }

        private void WithParsedAction(ShowOption obj)
        {
           _command.Execute(obj);
        }
    }
}