using System;
using System.IO;
using static System.Console;

namespace GOP_01
{
    internal class Ils54
    {
        protected static void Main(string[] args)
        {
            var filePath = args.Length > 0 ? args[0].Trim(' ', '"') : null;

            string[] sentences;

            var bigWord = 0;
            var numWord = 0;
            int numSentence;

            while (true)
            {
                string text;
                if (string.IsNullOrEmpty(filePath))
                {
                    WriteLine("Enter text to calculate LIX value from:");
                    text = ReadLine();
                }
                else
                {
                    text = File.Exists(filePath) ? File.ReadAllText(filePath) : null;
                }

                if (string.IsNullOrEmpty(text))
                {
                    WriteLine(
                        "Usage: \r\n\r\nYou must either type a text at the console, or write the path to a text file as a parameter");
                    ReadKey();
                    Clear();
                    continue;
                }
                else
                {
                    sentences = text.Trim()
                        .TrimEnd('.')
                        .Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
                    numSentence = sentences.Length;
                }
                break;
            }

            foreach (var sentence in sentences)
            {
                var words = sentence.Trim().Split(new[] {' ',',',';',':','(',')','\\'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (word.Length > 6)
                        bigWord++;
                    numWord++;
                }
            }

            var lix = Math.Round(bigWord * 100.0D / numWord + numWord / (double) numSentence, 0,
                MidpointRounding.AwayFromZero);

            if (lix <= 24.0)
                WriteLine($"LIX tal er {lix:N0}, der er i kategorien \"Meget Let\"");
            else if (lix <= 34.0)
                WriteLine($"LIX tal er {lix:N0}, der er i kategorien \"Let\"");
            else if (lix <= 44.0)
                WriteLine($"LIX tal er {lix:N0}, der er i kategorien \"Middel Svær\"");
            else if (lix <= 54.0)
                WriteLine($"LIX tal er {lix:N0}, der er i kategorien \"Svær\"");
            else
                WriteLine($"LIX tal er {lix:N0}, der er i kategorien \"Meget Svær\"");
        }
    }
}
