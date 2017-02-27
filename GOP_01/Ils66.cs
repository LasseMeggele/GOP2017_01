using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var months = TimeProgression(month, startRabbitPairs, maxSquareMeters * cagePrSquareMeter);

        }

        private static int TimeProgression(int month, int rabbitPairs, int maxRabbitPairs)
        {
            while (rabbitPairs < maxRabbitPairs)
            {

                month++;
            }
            return month;
        }


        private static int RabbitMachine(int rabbitPair) => rabbitPair * 3;
    }
}
