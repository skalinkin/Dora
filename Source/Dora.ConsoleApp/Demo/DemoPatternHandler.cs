using Avtec.DevMorningFix.Dora.BusinessCases;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal abstract class DemoPatternHandler
    {
        public virtual Demos Pattern { get; }

        public abstract void HandleRequest();
    }
}