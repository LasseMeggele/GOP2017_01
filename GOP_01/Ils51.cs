using System;

namespace GOP_01
{
    internal class Ils51
    {
        protected static void Main(string[] args)
        {
            var bContinue = false;

            do
            {
                Console.WriteLine("Enter text to replace word from:");
                var sentence = Console.ReadLine();

                Console.WriteLine("Enter word to replace:");
                var oldWord = Console.ReadLine();

                Console.WriteLine("Enter new word:");
                var newWord = Console.ReadLine();

                if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(oldWord) || string.IsNullOrEmpty(newWord))
                {
                    Console.WriteLine("You must enter a sentence and word to replace.");
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("Original sentence entered was: ");
                Console.WriteLine(sentence);
                Console.WriteLine();
                Console.WriteLine("New sentence is:");
                Console.WriteLine(sentence.Replace(oldWord, newWord));
                Console.WriteLine();
                Console.WriteLine("Press \"J\" to try again. ");
                var readLine = Console.ReadLine();
                if (readLine != null && readLine.ToLower() == "j") bContinue = true;

            } while (bContinue);
        }
    }
}
