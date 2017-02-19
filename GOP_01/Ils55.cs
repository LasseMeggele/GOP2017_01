using static System.Console;

namespace GOP_01
{
    internal class Ils55
    {
        public static void Main(string[] args)
        {
            var bContinue = false;
            
            do
            {
                string sCprNumber;
                var coefficient = 0;
                var sum = 0;

                Clear();
                WriteLine("Skriv CPR-nummer der skal testes:");
                var readline = ReadLine();
                if (!string.IsNullOrEmpty(readline) && readline.Length >= 10 && readline.Length <= 11)
                {
                    sCprNumber = readline.Replace("-", "");
                }
                else
                {
                    WriteLine("Du skal angive et CPR-nummer som \"012345-6789\". ");
                    ReadKey();
                    continue;
                }

                var arrCprNumber = sCprNumber.ToCharArray();
                for (var i = 0; i < arrCprNumber.Length; i++)
                {
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
                    }
                    //Console.WriteLine($"faktor {faktor}, tal {arrCprNummer[i]}, Sum {sum}");

                    var result = int.TryParse(arrCprNumber[i].ToString(), out var digit);
                    if (result)
                    {
                        sum += digit * coefficient;
                    }
                    else
                    {
                        WriteLine("Beregning fejlede da det indtastede ikke er et tal. ");
                        break;
                    }
                }

                WriteLine(sum % 11 == 0
                    ? "Det angivne CPR-nummer overholder modulus 11 reglen. "
                    : "Det angivne CPR-nummer overholder ikke Modulus 11 reglen. ");
                WriteLine();
                WriteLine("Press \"J\" to try again:");
                readline = ReadLine();
                if (readline != null && readline.ToLower() == "j") bContinue = true;
            } while (bContinue);
        }
    }
}
