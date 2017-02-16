using System;

namespace GOP_01
{
    internal class Tabel
    {
        private static void Main()
        {
            var s = "";

            for (var i = 1; i <= 10; ++i)
            {
                for (var j = 1; j <= 10; ++j)
                    s += $"{j * i,6}";
                s += "\r\n";
            }
            Console.WriteLine(s);
        }
    }
}
