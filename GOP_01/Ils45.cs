using static System.Console;

namespace GOP_01
{
    internal class Ils45
    {
        internal static void Main(string[] args)
        {
            int tabel;
            var i = 1;

            WriteLine("Angiv hvilken tabel vil du se: ");
            var result = int.TryParse(ReadLine(), out tabel);

            if (result && tabel > 0 && tabel < 1000)
            {
                Clear();
                WriteLine($"{tabel}-tabellen:");
                WriteLine(new string('_', 7));
                while (i <= 10)
                {
                    WriteLine($"{i,-2}|{tabel * i, 4}");
                    i++;
                }
            }
        }
    }
}