using System;
using System.IO;

namespace GOP_01
{
    class Opgave34
    {
        static void Main()
        {
            const double rabatsats = 10;
            const string format = "{0,-40}{1,40}";

            Console.WriteLine("Indtast længden på tæppet i meter: ");
            var laengde = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast breden af tæppet i meter: ");
            var brede = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast kvadratmeterprisen: ");
            var kvadratmeterpris = double.Parse(Console.ReadLine());

            var areal = laengde * brede;
            var pris = areal * kvadratmeterpris;
            var rabat = pris * rabatsats / 100;
            var rabatpris = pris - rabat;

            Console.WriteLine($"Antalet af kvadratmeter tæppe er: {areal}m²");
            Console.WriteLine($"Pris for tæppet er: {pris:c}");
            Console.WriteLine($"Rabatten er {rabatsats / 100:P}: {rabat:c}");
            Console.WriteLine($"Samlet pris er {rabatpris:c}");
            Console.WriteLine();

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

            Console.WriteLine("Udskriv faktura til fil J/N?");
            var svar = Console.ReadLine();

            if (svar == "J" || svar == "j")
            {
                var path = Environment.ExpandEnvironmentVariables("%TEMP%\\Faktura.txt");
                File.WriteAllText(path, s);
                System.Diagnostics.Process.Start(Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\notepad.exe"),
                    path);
            }
        }
    }
}
