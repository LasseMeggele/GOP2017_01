using System;

namespace GOP_01
{
    internal class Ils61
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(BeregnSekunder(24,35,46));
            Console.WriteLine(BeregnSekunder(40,0,0));
        }

        private static int BeregnSekunder(int timer, int minutter, int sekunder)
        {
            return timer * (int)Math.Pow(60, 2) + minutter * 60 + sekunder;
        }
    }
}
