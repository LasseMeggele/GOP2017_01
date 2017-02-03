using System;

namespace GOP_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            Console.WriteLine($"Today is the {DateTime.Today:D}");
            Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write($"Hi {name}, how are you?" );
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
