using static System.Console;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GOP_01
{
    internal class Ils37
    {
        private static void Main()
        {
            var valutakurserList = new List<Valutakurs>
            {
                new Valutakurs() { Name = "USD", Description = "US dollar"     , ExchangeRate = 679.96 },
                new Valutakurs() { Name = "EUR", Description = "Euro"          , ExchangeRate = 733.73 },
                new Valutakurs() { Name = "NOK", Description = "Norske kroner" , ExchangeRate =  81.26 },
                new Valutakurs() { Name = "SEK", Description = "Svenske kroner", ExchangeRate =  76.25 }
            };

            while (true)
            {
                WriteLine("Vælg valuta at omregne fra: ");
                for (var i = 0; i < valutakurserList.Count; i++)
                {
                    WriteLine($"  {i}: {valutakurserList[i].Name} - {valutakurserList[i].Description}");
                }

                var result = int.TryParse(ReadLine(), out int index);
                if (!result)
                {
                    MessageBox.Show(
                        "Du skal vælge en valuta ved at taste tallet ud for den ønskede valuta. ",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    continue;
                }

                WriteLine("Indtast beløb der skal omregnes: ");
                result = double.TryParse(ReadLine(), out double beloeb);
                if (!result)
                {
                    MessageBox.Show(
                        "Indtast et beløb i den vælgte valuta der skal omregnes til danske kroner. ",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    continue;
                }

                WriteLine($"{beloeb:N} {valutakurserList[index].Name} er {beloeb * valutakurserList[index].ExchangeRate / 100:C2}");

                break;
            }

            ReadLine();
        }
    }

    internal class Valutakurs
    {
        public string Name         { get; set; }
        public string Description  { get; set; }
        public double ExchangeRate { get; set; }
    }
}
