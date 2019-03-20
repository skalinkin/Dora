using System;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal interface IVerbsLocator
    {
        Type[] GetVerbs();
    }
}