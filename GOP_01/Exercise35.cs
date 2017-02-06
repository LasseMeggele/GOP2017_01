// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Exercise35.cs" company="">
//   
// </copyright>
// <summary>
//   The exercise 35.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GOP_01
{
    using System.Collections.Generic;

    using static System.Console;

    /// <summary>
    /// The exercise 35.
    /// </summary>
    internal class Exercise35
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            int w, x, y, z;
            var resultList = new List<bool>();

            while (true)
            {
                WriteLine("Indtast w: ");
                resultList.Add(int.TryParse(ReadLine(), out w));
                WriteLine("Indtast x: ");
                resultList.Add(int.TryParse(ReadLine(), out x));
                WriteLine("Indtast y: ");
                resultList.Add(int.TryParse(ReadLine(), out y));
                WriteLine("Indtast z: ");
                resultList.Add(int.TryParse(ReadLine(), out z));

                if (resultList.Contains(false))
                {
                    WriteLine($"Alle værdier skal udfyldes. Prøv igen eller tryk CTRL+C for at afbryde.");
                    ReadKey();
                    resultList.Clear();
                    Clear();
                    continue;
                }

                break;
            }

            WriteLine($"Produktet er: {w * x * y * z}");
            ReadKey();
        }
    }
}
