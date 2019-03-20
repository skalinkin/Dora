using System;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal interface IOption
    {
        Type GetCommandType();
    }
}