using Avtec.DevMorningFix.Dora.BusinessCases;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal class StrategyDemoPatternHandler : DemoPatternHandler
    {
        private readonly IDemoPattern _demo;

        public StrategyDemoPatternHandler(IDemoPattern demo)
        {
            _demo = demo;
        }

        public override Demos Pattern => Demos.Strategy;

        public override void HandleRequest()
        {
            _demo.Execute();
        }
    }
}