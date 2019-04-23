using System;
using System.Media;

namespace Avtec.DevMorningFix.Dora
{
    internal class MeepMeep : ITransmitBehavior
    {
        public void Transmit(ITransmitReceiver output)
        {
            Console.WriteLine("Meeping now");
            SystemSounds.Beep.Play();
            Console.WriteLine("Meeping Dun");
        }
    }
}
