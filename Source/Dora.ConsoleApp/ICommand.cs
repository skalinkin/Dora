using Avtec.DevMorningFix.Dora.ConsoleApp.Demo;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    public interface ICommand
    {
        void Execute(object option);
    }
}