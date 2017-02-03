using System.Globalization;
using static System.Console;

namespace GOP_01
{
    internal class Opgave32
    {
        private static void Main(string[] args)
        {
            const int momssats = 25;
            WriteLine("Indtast en pris uden moms: ");

            var beloeb = double.Parse(ReadLine(), NumberStyles.AllowCurrencySymbol);
            var moms = beloeb * momssats / 100;
            var ialt = beloeb + moms;
            WriteLine($"Beløb: {beloeb:c}\r\nMoms: {moms:c}\r\ni alt: {ialt:c}");
            ReadLine();
        }
    }
}
