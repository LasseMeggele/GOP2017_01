using System.Collections.Generic;
using System.Windows.Forms;
using static System.Console;

namespace GOP_01
{
    internal class Ils35
    {
        private static void Main()
        {
            double hight, width, depth;
            var resultList = new List<bool>();

            while (true)
            {
                WriteLine("Angiv højden på flydestol i cm: ");
                resultList.Add(double.TryParse(ReadLine(), out hight));

                WriteLine("Angiv breden på flydestol i cm: ");
                resultList.Add(double.TryParse(ReadLine(), out width));

                WriteLine("Angiv dybden af flydestol i cm: ");
                resultList.Add(double.TryParse(ReadLine(), out depth));

                if (resultList.Contains(false))
                {
                    MessageBox.Show(
                        "Højde, brede og dybten skal være større end nul. Prøv igen. ", 
                        "Fejl i indtastning",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    resultList.Clear();
                    Clear();
                    continue;
                }

                break;
            }

            var flydestol = new Flydestol(hight, width, depth);
            WriteLine($"Rumfang af flydestol er : {flydestol.Rumfang()/1000000:N}m³");
            WriteLine($"Overflade af flydestol er: {flydestol.Overflade()/10000:N}m²");
            ReadLine();
        }
    }

    internal class Flydestol
    {
        public double Hight { get; private set; }
        public double Width { get; private set; }
        public double Depth { get; private set; }

        public Flydestol(double hight, double width, double depth)
        {
            Hight = hight;
            Width = width;
            Depth = depth;
        }

        public double Rumfang()
        {
            return Hight * Width * Depth;
        }

        public double Overflade()
        {
            return (Width * Depth) + (2 * Hight * Width) + (2 * Hight * Depth);
        }
    }
}
