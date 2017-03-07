using System;

namespace GOP_01
{
    internal class Ils64
    {
        private static void Main()
        {
            Console.WriteLine(RepeatCharacter('*'));
            Console.WriteLine();
            Console.WriteLine(RepeatCharacter('#', 20));
        }

        private static string RepeatCharacter(char c)
        {
            return new string(c, 40);
        }

        private static string RepeatCharacter(char c, int i)
        {
            return new string(c, i);
        }
    }
}
