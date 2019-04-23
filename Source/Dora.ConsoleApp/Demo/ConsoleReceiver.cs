using System;

namespace Avtec.DevMorningFix.Dora.ConsoleApp.Demo
{
    internal class ConsoleReceiver : ITransmitReceiver
    {
        void ITransmitReceiver.TransmitData(string data)
        {
            Console.WriteLine(data);
        }
    }
}