using System;
using System.Linq;
using static System.Console;

namespace GOP_01
{
    internal class Ils53
    {
        protected static void Main(string[] args)
        {
            var wordCounter = 0;

            WriteLine("Skriv tekst hvor antallet af ord skal tælles: ");
            var s = ReadLine();
            if (s != null)
            {
                var arrSentence = s.Trim().TrimEnd('.').Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
                wordCounter +=
                    arrSentence.Sum(
                        sentence =>
                            sentence.Trim().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Length);
            }

            WriteLine($"Der er \"{wordCounter}\" ord i den angivet sætning. ");
        }
    }
}
