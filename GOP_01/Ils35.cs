using System.Windows.Forms;
using static System.Console;

namespace GOP_01
{
    internal class Ils35
    {
        private static void Main()
        {
            double h, b, l;

            while (true)
            {
                WriteLine("Angiv højde på flydestol i cm: ");
                double.TryParse(ReadLine(), out h);

                WriteLine("Angiv brede på flydestol i cm: ");
                double.TryParse(ReadLine(), out b);

                WriteLine("Angiv længden af flydestol i cm: ");
                double.TryParse(ReadLine(), out l);

                if (!(h > 0.0) || !(b > 0.0) || !(l > 0.0))
                {
                    MessageBox.Show("Højde, brede og længde skal være større end nul. Prøv igen. ", "Fejl i indtastning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    continue;
                }

                break;
            }

            var flydestol = new Flydestol(h, b, l);
            WriteLine($"Rumfang af flydestol er : {flydestol.Rumfang()/1000000:N}m³");
            WriteLine($"Overflade af flydestol er: {flydestol.Overflade()/10000:N}m²");
            ReadLine();
        }
    }

    internal class Flydestol
    {
        public double Højde { get; private set; }
        public double Brede { get; private set; }
        public double Længde { get; private set; }

        public Flydestol(double højde, double brede, double længde)
        {
            Højde = højde;
            Brede = brede;
            Længde = længde;
        }

        public double Rumfang()
        {
            return Højde * Brede * Længde;
        }

        public double Overflade()
        {
            return (Brede * Længde) + (2 * Højde * Brede) + (2 * Højde * Længde);
        }
    }
}
