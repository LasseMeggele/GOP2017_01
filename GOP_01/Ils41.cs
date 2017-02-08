// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ils41.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Ils41 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GOP_01
{
    using static System.Console;

    /// <summary>
    /// The Ils41 class.
    /// </summary>
    internal class Ils41
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            int weight;

            while (true)
            {
                WriteLine("Angiv vægten af forsendelsen i gram: ");
                var result = int.TryParse(ReadLine(), out weight);

                if (!result)
                {
                    WriteLine("Angiv vægten som et positivt heltal, eller afbryd med CTRL+C. ");
                    ReadKey();
                    continue;
                }

                break;
            }

            WriteLine(weight > 1000
                ? $"Forsendelsen er en pakke på {(double)weight / 1000:N2} kg"
                : $"Forsendelsen er et brev på {weight:N0} g");
        }
    }
}
