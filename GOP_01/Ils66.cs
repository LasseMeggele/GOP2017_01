using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOP_01
{
    class Ils66
    {
        static void Main(string[] args)
        {
            var startRabbitPairs = 4;
            var month = 0;
            var cagePrSquareMeter = 4;
            var maxSquareMeters = 2000;
            var maxRabbitPairs = cagePrSquareMeter * maxSquareMeters;

            var r = new Rabbits(month, startRabbitPairs);

            //Console.WriteLine($"Total months to fill the farm: {months}");

            while (r.Rabbitpairs <= maxRabbitPairs)
            {
                
                month++;
            }

        }



        struct Rabbits
        {
            public int Age { get; set; }
            public int Rabbitpairs { get; set; }

            public Rabbits(int age, int rabbitPairs)
            {
                this.Age = age;
                this.Rabbitpairs = rabbitPairs;
            }

            private static int TimeProgression(int month, int rabbitPairs)
            {
                month -= 9;
                if (month >= 0 && month % 5 == 0)
                {
                    rabbitPairs += RabbitMachine(rabbitPairs);
                }

                return rabbitPairs;
            }

            private static int RabbitMachine(int rabbitPair) => rabbitPair * 3;
        }

    }
}
