using System;
using System.Diagnostics;
using Avtec.DevMorningFix.Dora.BusinessCases;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal class DemoCommand : ICommand
    {
        private readonly Func<IDemoStrategyPattern> _strategyDemoFactory;

        public DemoCommand(Func<IDemoStrategyPattern> strategyDemoFactory)
        {
            _strategyDemoFactory = strategyDemoFactory;
        }
        public void Execute(object option)
        {
            var demoOption = (DemoOption) option;
            Debug.Print(demoOption.Pattern.ToString());
            if (demoOption.Pattern == Demos.Strategy)
            {
                StrategyDemo();
            }
        }

        private void StrategyDemo()
        {
            var businessCase = _strategyDemoFactory.Invoke();
            businessCase.Execute();
        }
    }
}