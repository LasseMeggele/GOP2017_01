using System;
using static System.Console;

namespace GOP_01
{
    internal class Ils57
    {
        private static void Main()
        {
            var tabel = new int[5, 3];
            var ttalObjekt = new Random();  //tilfældigt ttal

            for (var i = 0; i < 5; i++)   //5 rækker
                for (var j = 0; j < 3; j++) //3 søjler
                    tabel[i, j] = ttalObjekt.Next(1, 7);

            WriteLine("Der blev udtrukket følgende tal");

            for (var i = 0; i < 5; i++)   //5 rækker
            {
                for (var j = 0; j < 3; j++) //3 søjler
                    Write($" {tabel[i, j]}");

                WriteLine();
            }
            ReadLine();
        }
    }
}
