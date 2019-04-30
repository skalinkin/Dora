using Avtec.DevMorningFix.Dora.BusinessCases;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal class ObserverDemoPatternHandler : DemoPatternHandler
    {
        private readonly IDemoPattern _demo;

        public ObserverDemoPatternHandler(IDemoPattern demo)
        {
            _demo = demo;
        }

        public override Demos Pattern => Demos.Observer;

        public override void HandleRequest()
        {
            _demo.Execute();
        }
    }
}