using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CommandLine;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal class DoraArgumentsProcessor : IStart
    {
        private readonly IVerbsLocator _verbsLocator;
        private readonly IEnumerable<ICommand> _commands;

        public DoraArgumentsProcessor(IVerbsLocator verbsLocator, IEnumerable<ICommand> commands)
        {
            _verbsLocator = verbsLocator;
            _commands = commands;
        }
        private void HandleParseError(IEnumerable<Error> obj)
        {
            foreach (var error in obj)
            {
                Debug.Print($"Error during parsing{error.Tag.ToString()}");
            }
        }

        private void WithParsedAction(object option)
        {
            var theOption = (IOption) option;
            var command = _commands.First(c => c.GetType() == theOption.GetCommandType());
            command.Execute(option);
        }

        public void Execute(string[] args)
        {
            var verbs = _verbsLocator.GetVerbs();
            var result = Parser.Default.ParseArguments(args,verbs);
            result.WithParsed(WithParsedAction);
            result.WithNotParsed(HandleParseError);
        }
    }
}