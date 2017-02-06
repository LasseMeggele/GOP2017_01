using System;
using static System.Console;
using System.IO;

namespace GOP_01
{
    internal class Ils34
    {
        private static void Main()
        {
            const double rabatsats = 10;
            const string format = "{0,-40}{1,40}";

            double laengde, brede, kvadratmeterpris;

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

            var areal = laengde * brede;
            var pris = areal * kvadratmeterpris;
            var rabat = pris * rabatsats / 100;
            var rabatpris = pris - rabat;

            WriteLine($"Antalet af kvadratmeter tæppe er: {areal}m²");
            WriteLine($"Pris for tæppet er: {pris:c}");
            WriteLine($"Rabatten er {rabatsats / 100:P}: {rabat:c}");
            WriteLine($"Samlet pris er {rabatpris:c}");
            WriteLine();

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
                System.Diagnostics.Process.Start(Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\notepad.exe"),
                    path);
            }
        }
    }
}
