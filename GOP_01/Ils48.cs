namespace GOP_01
{
    using static System.Console;

    internal class Ils48
    {
        protected static void Main(string[] args)
        {

            WriteLine("Angiv hvilken tabel vil du se: ");
            var result = int.TryParse(ReadLine(), out int tabel);

            if (result && tabel > 0 && tabel < 1000)
            {
                Clear();
                WriteLine($"{tabel}-tabellen:");
                WriteLine(new string('_', 7));

                for (var i = 0; i <= 10; i++)
                {
                    WriteLine($"{i,-2}|{tabel * i,4}");
                }
            }
        }
    }
}
