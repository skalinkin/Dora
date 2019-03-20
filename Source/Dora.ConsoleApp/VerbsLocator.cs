using System;
using Avtec.DevMorningFix.Dora.ConsoleApp.Demo;
using Avtec.DevMorningFix.Dora.ConsoleApp.Show;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal class VerbsLocator : IVerbsLocator
    {
        public Type[] GetVerbs()
        {
            return new[]
            {
                typeof(ShowOption), typeof(DemoOption)
            };
        }
    }
}