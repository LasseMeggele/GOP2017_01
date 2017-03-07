using System;

namespace GOP_01
{
    internal class Ils62
    {
        private static void Main()
        {
            Console.WriteLine(LargerNumber(4, 5));
            Console.WriteLine(LargerNumber(4, 4));
            Console.WriteLine(LargerNumber(6, 4));
        }

        private static int LargerNumber(int a, int b) => a > b ? a : b;
    }
}
