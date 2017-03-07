using static System.Console;

namespace GOP_01
{
    internal class Ils65
    {
        private static void Main()
        {
            WriteLine(Multiply(3, 5));
            WriteLine(Multiply(3.0D, 5.0D));
        }

        private static int Multiply(int a, int b) => a * b;

        private static double Multiply(double a, double b) => a * b;
    }
}
