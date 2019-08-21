using System;
using System.Threading;
using RouletteWheel;

namespace RouletteWheel
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            Console.WriteLine(Bets.zeros[1]);
        }
        static void Title()
        {
            string title = 
            
                @" ________  ________  ___  ___  ___       _______  _________  _________  _______      "+"\n"+
                @"|\   __  \|\   __  \|\  \|\  \|\  \     |\  ___ \|\___   ___\\___   ___\\  ___ \     "+"\n"+
                @"\ \  \|\  \ \  \|\  \ \  \\\  \ \  \    \ \   __/\|___ \  \_\|___ \  \_\ \   __/|    "+"\n"+
                @" \ \   _  _\ \  \\\  \ \  \\\  \ \  \    \ \  \_|/__  \ \  \     \ \  \ \ \  \_|/__  "+"\n"+
                @"  \ \  \\  \\ \  \\\  \ \  \\\  \ \  \____\ \  \_|\ \  \ \  \     \ \  \ \ \  \_|\ \ "+"\n"+
                @"   \ \__\\ _\\ \_______\ \_______\ \_______\ \_______\  \ \__\     \ \__\ \ \_______\"+"\n"+
                @"    \|__|\|__|\|_______|\|_______|\|_______|\|_______|   \|__|      \|__|  \|_______|"
            ;
            Console.WriteLine(title);
        }
        static void askToSpinWheel()
        {
            Console.WriteLine("Now its time to Spin! Press enter when ready");

        }
    }
}
