using static System.Console;

namespace GOP_01
{
    internal class Ils33
    {
        private static void Main()
        {
            const int momssats = 25;

            #region Intastning af data
            WriteLine("Indtast et varenavn: ");
            var vareNavn = ReadLine();

            WriteLine("Indtast en pris pr. vare uden moms: ");
            var s = ReadLine();
            if (string.IsNullOrEmpty(s))
                s = "0";

            var beloeb = double.Parse(s);

            WriteLine("Indtast antal: ");
            s = ReadLine();
            if (string.IsNullOrEmpty(s))
                s = "1";

            var antal = int.Parse(s);
            #endregion

            #region Beregninger
            var samletPris = beloeb * antal;
            var moms = samletPris * momssats / 100;
            var ialt = samletPris + moms;
            #endregion

            #region Visning af beregninger
            WriteLine();
            WriteLine($"Varenavn: {vareNavn}\r\n" +
                      $"Styk pris: {beloeb:C}\r\n" +
                      $"Antal: {antal:N}\r\n" +
                      $"Samlet Pris: {samletPris:c}\r\n" +
                      $"Moms: {moms:c}\r\n" +
                      $"Pris i alt: {ialt:c}\r\n");
            WriteLine("Tryk på Enter for at afslutte.");
            ReadLine();
            #endregion
        }
    }
}
