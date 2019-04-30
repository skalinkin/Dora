using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal class DemoCommand : ICommand
    {
        private readonly IEnumerable<DemoPatternHandler> _handlers;

        public DemoCommand(IEnumerable<DemoPatternHandler> handlers)
        {
            _handlers = handlers;
        }

        public void Execute(object option)
        {
            var demoOption = (DemoOption) option;
            Debug.Print(demoOption.Pattern.ToString());

            var handler = _handlers.Single(h => h.Pattern == demoOption.Pattern);
            handler.HandleRequest();
        }
    }
}