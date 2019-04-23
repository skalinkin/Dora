using System;

namespace Avtec.DevMorningFix.Dora
{
    internal class RGBTransmitBehavior : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            ConsoleColor origForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            output.TransmitData("Begin Transmitting");
            Console.ForegroundColor = ConsoleColor.Green;
            output.TransmitData("Still Transmitting");
            Console.ForegroundColor = ConsoleColor.Blue;
            output.TransmitData("End Transmitting");
            Console.ForegroundColor = origForeground;
        }
    }
}
