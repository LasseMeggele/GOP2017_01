using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOP_01
{
    internal class Ils58
    {
        protected static void Main()
        {
            var arrStack = new int[10];
            var top = -1;

            var rnd = new Random();

            //push int to array
            Console.WriteLine("Define the content of the stack.");
            while (top < arrStack.Length - 1)
            {
                top++;
                arrStack[top] = rnd.Next(0, 100);
                Console.WriteLine($"{top}: {arrStack[top]}");

            }
            Console.WriteLine();

            //peek to top index
            Console.WriteLine("Peek top of stack:");
            Console.WriteLine($"{top}: {arrStack[top]}");
            Console.WriteLine();

            //pop an int of the array
            var i = arrStack[top];
            arrStack[top] = 0;
            top--;
            
            //peek top index
            Console.WriteLine("peek top of stack after pop:");
            Console.WriteLine($"{top}: {arrStack[top]}");
            Console.WriteLine();

            //pop another from the stack
            i = arrStack[top];
            arrStack[top] = 0;
            top--;

            Console.WriteLine("Peek the content of the stack");
            foreach (var value in arrStack)
            {
                Console.WriteLine($"{value}");
            }
            Console.WriteLine();

            Console.WriteLine($"top pointer is {top}");
        }

    }
}
