using System;
using static System.Console;

namespace GOP_01
{
    internal class Ils43
    {
        private static void Main()
        {
            string kundetype = null;
            double pris;
            byte rabat;
            string[] kundetyper = { "a", "b", "c" };

            while (true)
            {
                WriteLine(value: "Angiv kundetype: ");
                foreach (var s in kundetyper)
                {
                    WriteLine(value: $"{s.ToUpper(),2}:");
                }
                var readLine = ReadLine();
                if (readLine != null) kundetype = readLine.ToLower();

                if (!Array.Exists(array: kundetyper, match: x => kundetype != null && x == kundetype.ToLower()))
                {
                    WriteLine(value: "Angiv kundetype, eller afbryd ved at trykke på CTRL+C. ");
                    ReadKey();
                    continue;
                }

                break;
            }

            while (true)
            {
                WriteLine(value: "Angiv købspris: ");
                var result = double.TryParse(s: ReadLine(), result: out pris);

                if (!result)
                {
                    WriteLine(value: "Angiv købspris, eller afbryd ved at trykke på CTRL+C. ");
                    ReadKey();
                    continue;
                }

                break;
            }

            if (kundetype == null) return;
            switch (kundetype.ToLower())
            {
                case "a":
                    {
                        rabat = 10;
                        break;
                    }
                case "b":
                    {
                        rabat = 5;
                        break;
                    }
                default:
                    {
                        rabat = 0;
                        break;
                    }
            }

            WriteLine(value: $"Kundetype ({kundetype.ToUpper()}) får {rabat / 100.0D:P0} i rabat.");
            WriteLine(value: $"{"Købspris:",-12} {pris,18:C2}");
            WriteLine(value: $"{"Rabat",-12} {pris * rabat / 100,18:C2}");
            WriteLine(value: $"{"Samlet pris",-12} {pris - pris * rabat / 100,18:C2}");
        }
    }
}