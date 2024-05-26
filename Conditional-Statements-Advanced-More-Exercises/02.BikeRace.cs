using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsBikers = int.Parse(Console.ReadLine());
            int seniorsBikers = int.Parse(Console.ReadLine());
            string typeTrace = Console.ReadLine();
            double donatedSum = 0.0;
            if (typeTrace == "trail")
            {
                donatedSum = (juniorsBikers * 5.50) + (seniorsBikers * 7);
                donatedSum *= 0.95;

            }
            else if (typeTrace == "cross-country")
            {
                donatedSum = (juniorsBikers * 8) + (seniorsBikers * 9.50);
                donatedSum *= 0.95;
                double totalBikers = juniorsBikers + seniorsBikers;
                if (totalBikers >= 50)
                {
                    donatedSum *= 0.75;
                }
            }
            else if (typeTrace == "downhill")
            {
                donatedSum = (juniorsBikers * 12.25) + (seniorsBikers * 13.75);
                donatedSum *= 0.95;
            }
            else if (typeTrace == "road")
            {
                donatedSum = (juniorsBikers * 20) + (seniorsBikers * 21.50);
                donatedSum *= 0.95;
            }
            Console.WriteLine($"{donatedSum:F2}");

        }
    }
}
