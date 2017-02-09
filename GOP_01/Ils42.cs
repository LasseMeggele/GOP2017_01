// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ils42.cs" company="">
//
// </copyright>
// <summary>
//   Defines the Ils42 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GOP_01
{
    using static System.Console;

    /// <summary>
    /// The Ils42 class.
    /// </summary>
    internal class Ils42
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            double purchase;
            int discount;

            while (true)
            {
                WriteLine($"Angiv samlet pris for at beregne rabat. ");
                var result = double.TryParse(ReadLine(), out purchase);

                if (!result)
                {
                    WriteLine($"Angiv den samlede pris for at beregne rabat, eller afbryd ved at trykke på CTRL+C. ");
                    ReadKey();
                    continue;
                }

                break;
            }

            if (purchase > 2000)
                discount = 10;
            else if (purchase > 1000 && purchase <= 2000)
                discount = 5;
            else
                discount = 0;

            WriteLine($"{"Købspris før rabat:",-20} {purchase,18:C2}");
            WriteLine($"{"Samlet rabat:",-20} {purchase * discount / 100.0D,18:C2}");
            WriteLine($"{"Pris efter rabat:",-20} {purchase - purchase * discount / 100.0D,18:C2}");
        }
    }
}