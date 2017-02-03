using System;
using static System.Console;
using System.Globalization;

namespace GOP_01
{
    internal class Opgave33
    {
        private static void Main(string[] args)
        {
            const int momssats = 25;
            WriteLine("Indtast et varenavn: ");
            var vareNavn = ReadLine();

            WriteLine("Indtast en pris pr. vare uden moms: ");
            var beloeb = double.Parse(ReadLine());

            WriteLine("Indtast antal: ");
            var antal = int.Parse(ReadLine());

            var samletPris = beloeb * antal;
            var moms = samletPris * momssats / 100;
            var ialt = samletPris + moms;
            WriteLine();
            WriteLine($"Varenavn: {vareNavn}\r\n" +
                      $"Styk pris: {beloeb:c}\r\n" +
                      $"Antal: {antal}\r\n" +
                      $"Samlet Pris: {samletPris:c}\r\n" +
                      $"Moms: {moms:c}\r\n" +
                      $"Pris i alt: {ialt:c}\r\n");
            WriteLine("Tryk på Enter for at afslutte.");
            ReadLine();
        }
    }
}
