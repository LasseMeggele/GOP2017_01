using System;
using static System.Console;

namespace GOP_01
{
    internal class Ils55
    {
        private static void Main()
        {
            var bContinue = false;
            
            do
            {
                string sCprNumber;

                Clear();
                WriteLine("Skriv CPR-nummer der skal testes:");
                var readline = ReadLine();
                if (!string.IsNullOrEmpty(readline) && readline.Length >= 10 && readline.Length <= 11)
                {
                    sCprNumber = readline;
                }
                else
                {
                    WriteLine("Du skal angive et CPR-nummer som \"012345-6789\". ");
                    ReadKey();
                    continue;
                }

                WriteLine(IsValidCprNumber(sCprNumber.Replace("-", "")) 
                    ? $"Det indtastede CPR-nummer \"{sCprNumber}\" overholder Modulus 11 testen."
                    : $"Det indtastede CPR-nummer \"{sCprNumber}\" overholder ikke Modulus 11 testen.");
                WriteLine();
                WriteLine("Press \"J\" to try again:");
                readline = ReadLine();
                if (readline != null && readline.ToLower() == "j") bContinue = true;
            } while (bContinue);
        }

        private static bool IsValidCprNumber(string sCprNumber)
        {
            if (string.IsNullOrEmpty(sCprNumber))
                throw new ArgumentException($"Parameter {nameof(sCprNumber)} cannot be null", nameof(sCprNumber));

            var sum = 0;
            var arrCprNumber = sCprNumber.ToCharArray();
            for (var i = 0; i < arrCprNumber.Length; i++)
            {
                int coefficient;
                switch (i)
                {
                    case 0: coefficient = 4; break;
                    case 1: coefficient = 3; break;
                    case 2: coefficient = 2; break;
                    case 3: coefficient = 7; break;
                    case 4: coefficient = 6; break;
                    case 5: coefficient = 5; break;
                    case 6: coefficient = 4; break;
                    case 7: coefficient = 3; break;
                    case 8: coefficient = 2; break;
                    case 9: coefficient = 1; break;
                    default: coefficient = 0; break;
                }

                var result = int.TryParse(arrCprNumber[i].ToString(), out var digit);
                if (result)
                    sum += digit * coefficient;
                else
                    throw new ArgumentException("Beregning fejlede da det indtastede ikke er et tal.", nameof(sCprNumber));
            }

            return sum % 11 == 0;
        }
    }
}
