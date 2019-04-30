using System;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal class ConsoleMonitorOutput : IMonitorOutput
    {
        public void Write(string subjectSubjectState)
        {
            Console.WriteLine(subjectSubjectState);
        }
    }
}