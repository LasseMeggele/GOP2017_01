using System.Collections.Generic;
using System.Windows.Forms;
using static System.Console;

namespace GOP_01
{
    internal class Ils36
    {
        private static void Main()
        {
            var valutakurserList = new List<Valutakurs>
            {
                new Valutakurs() { Name = "USD", Description = "US dollar"     , ExchangeRate = 709.40 },
                new Valutakurs() { Name = "EUR", Description = "Euro"          , ExchangeRate = 756.79 },
                new Valutakurs() { Name = "NOK", Description = "Norske kroner" , ExchangeRate = 84.99  },
                new Valutakurs() { Name = "SEK", Description = "Svenske kroner", ExchangeRate = 80.00  }
            };

            while (true)
            {
                var result = false;

                WriteLine("Indtast beløb i DKK: ");
                double beloeb;
                result = double.TryParse(ReadLine(), out beloeb);
                if (!result)
                {
                    MessageBox.Show(
                        "Indtast et beløb i danske kroner der skal omregnes til anden valuta. ",
                        "Information", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    Clear();
                    continue;
                }

                WriteLine("Vælg valuta at omregne til: ");
                for (var i = 0; i < valutakurserList.Count; i++)
                {
                    WriteLine($"  {i}: {valutakurserList[i].Name} - {valutakurserList[i].Description}");
                }

                int selection;
                result = int.TryParse(ReadLine(), out selection);
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

                WriteLine(
                    $"{beloeb:C} er {(beloeb / valutakurserList[selection].ExchangeRate) * 100:N2} {valutakurserList[selection].Name}");

                break;
            }

            ReadLine();
        }
    }

    internal class Valutakurs
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ExchangeRate { get; set; }
    }
}
