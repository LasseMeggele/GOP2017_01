using System;
using static System.Console;

namespace GOP_01
{
    internal class Ils52
    {
        protected static void Main(string[] args)
        {
            var bContinue = false;

            do
            {
                var sentence = "";

                Clear();
                WriteLine("Enter sentence to clean:");
                var readline = ReadLine();
                if (!string.IsNullOrEmpty(readline)) sentence = readline;
                var arrSentence = sentence.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                sentence = string.Join(" ", arrSentence);

                WriteLine(sentence);
                WriteLine();
                WriteLine("Press \"J\" to try again:");
                readline = ReadLine();
                if (readline != null && readline.ToLower() == "j") bContinue = true;

            } while (bContinue);
        }
    }
}
