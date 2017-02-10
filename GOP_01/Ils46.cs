using System;
using static System.Console;

namespace GOP_01
{
    internal class Ils46
    {
        internal static void Main(string[] args)
        {
            var s = "j";
            while (string.Equals(s, "j", StringComparison.InvariantCultureIgnoreCase))
            {
                var i = 1;

                Clear();
                WriteLine("Angiv hvilken tabel vil du se: ");
                var result = int.TryParse(ReadLine(), out int tabel);

                if (result && tabel > 0 && tabel < 1000)
                {
                    Clear();
                    WriteLine($"{tabel}-tabellen:");
                    WriteLine(new string('_', 7));
                    while (i <= 10)
                    {
                        WriteLine($"{i,-2}|{tabel * i,4}");
                        i++;
                    }
                }
                else
                    WriteLine("Vælg et heltal over 0 og under 1000. ");

                WriteLine();
                WriteLine("Vil du oprette en ny tabel? (J/N)");
                s = ReadLine();
            }
        }
    }
}