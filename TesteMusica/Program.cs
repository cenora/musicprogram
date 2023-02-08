using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace MusicBeep
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        public static void Main(string[] args)
        {
            //Console.WriteLine("beep");
            //Beep(1000, 1000);
            //Console.WriteLine("beep alto curto");
            Beep(2000, 500);
            //Piano();
        }

        private static void Mario()
        {
            Beep(659, 125); Beep(659, 125); Thread.Sleep(125); Beep(659, 125);
            Thread.Sleep(167); Beep(523, 125); Beep(659, 125); Thread.Sleep(125);
            Beep(784, 125); Thread.Sleep(375); Beep(392, 125); Thread.Sleep(375);
            Beep(523, 125); Thread.Sleep(250); Beep(392, 125); Thread.Sleep(250);
            Beep(330, 125); Thread.Sleep(250); Beep(440, 125); Thread.Sleep(125);
            Beep(494, 125); Thread.Sleep(125); Beep(466, 125); Thread.Sleep(42);
            Beep(440, 125); Thread.Sleep(125); Beep(392, 125); Thread.Sleep(125);
            Beep(659, 125); Thread.Sleep(125); Beep(784, 125); Thread.Sleep(125);
            Beep(880, 125); Thread.Sleep(125); Beep(698, 125); Beep(784, 125);
            Thread.Sleep(125); Beep(659, 125); Thread.Sleep(125); Beep(523, 125);
            Thread.Sleep(125); Beep(587, 125); Beep(494, 125); Thread.Sleep(125);
            Beep(523, 125); Thread.Sleep(250); Beep(392, 125); Thread.Sleep(250);
            Beep(330, 125); Thread.Sleep(250); Beep(440, 125); Thread.Sleep(125);
            Beep(494, 125); Thread.Sleep(125); Beep(466, 125); Thread.Sleep(42);
            Beep(440, 125); Thread.Sleep(125); Beep(392, 125); Thread.Sleep(125);
            Beep(659, 125); Thread.Sleep(125); Beep(784, 125); Thread.Sleep(125);
            Beep(880, 125); Thread.Sleep(125); Beep(698, 125); Beep(784, 125);
            Thread.Sleep(125); Beep(659, 125); Thread.Sleep(125); Beep(523, 125);
            Thread.Sleep(125); Beep(587, 125); Beep(494, 125); Thread.Sleep(375);
            Beep(784, 125); Beep(740, 125); Beep(698, 125); Thread.Sleep(42);
            Beep(622, 125); Thread.Sleep(125); Beep(659, 125); Thread.Sleep(167);
            Beep(415, 125); Beep(440, 125); Beep(523, 125); Thread.Sleep(125);
            Beep(440, 125); Beep(523, 125); Beep(587, 125); Thread.Sleep(250);
            Beep(784, 125); Beep(740, 125); Beep(698, 125); Thread.Sleep(42);
            Beep(622, 125); Thread.Sleep(125); Beep(659, 125); Thread.Sleep(167);
            Beep(698, 125); Thread.Sleep(125); Beep(698, 125); Beep(698, 125);
            Thread.Sleep(625); Beep(784, 125); Beep(740, 125); Beep(698, 125);
            Thread.Sleep(42); Beep(622, 125); Thread.Sleep(125); Beep(659, 125);
            Thread.Sleep(167); Beep(415, 125); Beep(440, 125); Beep(523, 125);
            Thread.Sleep(125); Beep(440, 125); Beep(523, 125); Beep(587, 125);
            Thread.Sleep(250); Beep(622, 125); Thread.Sleep(250); Beep(587, 125);
            Thread.Sleep(250); Beep(523, 125); Thread.Sleep(1125); Beep(784, 125);
            Beep(740, 125); Beep(698, 125); Thread.Sleep(42); Beep(622, 125);
            Thread.Sleep(125); Beep(659, 125); Thread.Sleep(167); Beep(415, 125);
            Beep(440, 125); Beep(523, 125); Thread.Sleep(125); Beep(440, 125);
            Beep(523, 125); Beep(587, 125); Thread.Sleep(250); Beep(784, 125);
            Beep(740, 125); Beep(698, 125); Thread.Sleep(42); Beep(622, 125);
            Thread.Sleep(125); Beep(659, 125); Thread.Sleep(167); Beep(698, 125);
            Thread.Sleep(125); Beep(698, 125); Beep(698, 125); Thread.Sleep(625);
            Beep(784, 125); Beep(740, 125); Beep(698, 125); Thread.Sleep(42);
            Beep(622, 125); Thread.Sleep(125); Beep(659, 125); Thread.Sleep(167);
            Beep(415, 125); Beep(440, 125); Beep(523, 125); Thread.Sleep(125);
            Beep(440, 125); Beep(523, 125); Beep(587, 125); Thread.Sleep(250);
            Beep(622, 125); Thread.Sleep(250); Beep(587, 125); Thread.Sleep(250);
            Beep(523, 125);
        }

        private static void Parabens()
        {
            Thread.Sleep(2000);
            Beep(264, 125);
            Thread.Sleep(250);
            Beep(264, 125);
            Thread.Sleep(125);
            Beep(297, 500);
            Thread.Sleep(125);
            Beep(264, 500);
            Thread.Sleep(125);
            Beep(352, 500);
            Thread.Sleep(125);
            Beep(330, 1000);
            Thread.Sleep(250);
            Beep(264, 125);
            Thread.Sleep(250);
            Beep(264, 125);
            Thread.Sleep(125);
            Beep(297, 500);
            Thread.Sleep(125);
            Beep(264, 500);
            Thread.Sleep(125);
            Beep(396, 500);
            Thread.Sleep(125);
            Beep(352, 1000);
            Thread.Sleep(250);
            Beep(264, 125);
            Thread.Sleep(250);
            Beep(264, 125);
            Thread.Sleep(125);
            Beep(2642, 500);
            Thread.Sleep(125);
            Beep(440, 500);
            Thread.Sleep(125);
            Beep(352, 250);
            Thread.Sleep(125);
            Beep(352, 125);
            Thread.Sleep(125);
            Beep(330, 500);
            Thread.Sleep(125);
            Beep(297, 1000);
            Thread.Sleep(250);
            Beep(466, 125);
            Thread.Sleep(250);
            Beep(466, 125);
            Thread.Sleep(125);
            Beep(440, 500);
            Thread.Sleep(125);
            Beep(352, 500);
            Thread.Sleep(125);
            Beep(396, 500);
            Thread.Sleep(125);
            Beep(352, 1000);
        }

        private static void Piano()
        {
            int[] freq = { 261, 277, 293, 311, 329, 349, 415, 440, 466, 493 }; //C, C#, D, Eb, E, F, F#, G, G#, A, Bb, B
            int duration = 250;

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        Beep(freq[0], duration);
                        break;
                    case ConsoleKey.S:
                        Beep(freq[2], duration);
                        break;
                    case ConsoleKey.D:
                        Beep(freq[4], duration);
                        break;
                    case ConsoleKey.F:
                        Beep(freq[5], duration);
                        break;
                    case ConsoleKey.G:
                        Beep(freq[7], duration);
                        break;
                    case ConsoleKey.H:
                        Beep(freq[5], duration);
                        break;
                    case ConsoleKey.J:
                        Beep(freq[6], duration);
                        break;
                    case ConsoleKey.K:
                        Beep(freq[7], duration);
                        break;
                    case ConsoleKey.L:
                        Beep(freq[8], duration);
                        break;
                }
            }
        }

    }
}


