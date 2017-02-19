using System;
using System.Linq;
using static System.Console;

namespace GOP_01
{
    internal class Ils56
    {
        protected static void Main()
        {
            var arrNumbers = new int[10];
            var rnd = new Random();

            for (var i = 0; i < arrNumbers.Length; i++)
                arrNumbers[i] = rnd.Next(0, 100);

            WriteLine($"Array of numbers:                               {string.Join(", ", arrNumbers)}");
            WriteLine($"Array sorted i assending order:                 {string.Join(", ", arrNumbers.OrderBy(x => x))}");
            WriteLine($"Array sorted in descending order:               {string.Join(", ", arrNumbers.OrderByDescending(x => x))}");
            WriteLine($"The lowest number in array is:                  {arrNumbers.Min()}");
            WriteLine($"The index of the lowest number in the array is: {GetIndexOfLowestInteger(arrNumbers)}");
            WriteLine($"The highest number in array is:                 {arrNumbers.Max()}");
            WriteLine($"The average value of the array is:              {arrNumbers.Average()}");
        }

        private static int GetIndexOfLowestInteger(int[] arrInt)
        {
            if (arrInt == null) throw new ArgumentNullException(nameof(arrInt));

            var index = 0;

            for (var i = 0; i < arrInt.Length; i++)
                if (arrInt[i] < arrInt[index]) index = i;

            return index;
        }
    }
}
