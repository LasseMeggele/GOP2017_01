using System;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace GOP_01
{
    internal class Ils44
    {
        private static void Main()
        {
            #region Konstanter og variable

            const string format = "{0,-41}{1,41}";

            string[] kundetyper = { "a", "b", "c" };
            string kundetype = null;
            short rabatsats;
            double laengde, brede, kvadratmeterpris;

            #endregion

            #region Indtastning af data

            while (true)
            {
                WriteLine(value: "Angiv kundetype: ");
                foreach (var type in kundetyper)
                {
                    WriteLine(value: $"{type.ToUpper(),2}:");
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
                WriteLine("Indtast længden på tæppet i meter: ");
                double.TryParse(ReadLine(), out laengde);

                WriteLine("Indtast breden af tæppet i meter: ");
                double.TryParse(ReadLine(), out brede);

                WriteLine("Indtast kvadratmeterprisen: ");
                double.TryParse(ReadLine(), out kvadratmeterpris);

                if (!(laengde > 0.0) || !(brede > 0.0) || !(kvadratmeterpris > 0.0))
                {
                    WriteLine("Indtast tæppets længde, brede og kvadratmeterpris, for at beregne den samlede pris.\r\n" +
                              "Tryk en tast for at prøve igen, eller tryk på CTRL+C for at afbryde. ");
                    ReadKey();
                    Clear();
                    continue;
                }
                break;
            }

            #endregion

            #region Beregning

            var areal = laengde * brede;
            var pris = areal * kvadratmeterpris;
            double rabat;

            if (kundetype == null) return;
            switch (kundetype.ToLower())
            {
                case "a":
                {
                    rabatsats = 5;
                    rabat = pris * rabatsats / 100.0D;
                    break;
                }
                case "b":
                {
                    rabatsats = 10;
                    rabat = pris * rabatsats / 100.0D;
                    break;
                }
                case "c":
                {
                    if (pris > 1000)
                    {
                        rabatsats = 10;
                        rabat = pris * rabatsats / 100.0D;
                    }
                    else
                    {
                        rabatsats = 0;
                        rabat = 0.0;
                    }

                    break;
                }
                default:
                {
                    rabatsats = 0;
                    rabat = 0.0;
                    break;
                }
            }

            var rabatpris = pris - rabat;

            #endregion

            #region Vis resultat

            WriteLine($"Antalet af kvadratmeter tæppe er: {areal}m²");
            WriteLine($"Pris for tæppet er: {pris:c}");
            WriteLine($"Rabatten er {rabatsats / 100.0D:P}: {rabat:c}");
            WriteLine($"Samlet pris er {rabatpris:c}");
            WriteLine();

            #endregion

            #region Faktura

            var s = new string('-', 80) + "\r\n";
            s += string.Format(format, "Faktura", $"{DateTime.Today:D}\r\n");
            s += new string('-', 80) + "\r\n";
            s += string.Format(format, "Tæppets længde:", $"{laengde:N2}m\r\n");
            s += string.Format(format, "Tæppets brede:", $"{brede:N2}m\r\n");
            s += string.Format(format, "Tæppets areal:", $"{areal:N2}m²\r\n");
            s += string.Format(format, "Tæppets kvadratmeter pris:", $"{kvadratmeterpris:C}\r\n");
            s += string.Format(format, "Tæppets pris:", $"{pris:C}\r\n");
            s += string.Format(format, "Tæppets rabat:", $"{rabat:C}\r\n");
            s += new string('-', 80) + "\r\n";
            s += string.Format(format, "Tæppets pris i alt:", $"{rabatpris:C}\r\n");
            s += new string('-', 80) + "\r\n";

            WriteLine("Udskriv faktura til fil J/N?");
            var svar = ReadLine();

            if (svar != null && svar.ToUpperInvariant() == "J")
            {
                var path = Environment.ExpandEnvironmentVariables("%TEMP%\\Faktura.txt");
                File.WriteAllText(path, s);
                Process.Start(Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\notepad.exe"),
                    path);
            }

            #endregion
        }
    }
}