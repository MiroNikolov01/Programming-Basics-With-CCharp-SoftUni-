using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEasterBread = int.Parse(Console.ReadLine());
            int totalNeededSugar = 0;
            int totalNeededFlour = 0;
            int maxFlour = int.MinValue;
            int maxSugar = int.MinValue;

            for (int i = 0; i < countEasterBread; i++)
            {
                int usedSugar = int.Parse(Console.ReadLine());
                int usedFlour = int.Parse(Console.ReadLine());
                if (maxFlour < usedFlour)
                {
                    maxFlour = usedFlour;
                }
                if (maxSugar < usedSugar)
                {
                    maxSugar = usedSugar;
                }
                totalNeededSugar += usedSugar;
                totalNeededFlour += usedFlour;

            }
                double packageSugar = Math.Ceiling((double)totalNeededSugar / 950);
                double packageFlour = Math.Ceiling((double)totalNeededFlour / 750);
            Console.WriteLine($"Sugar: {packageSugar}");
            Console.WriteLine($"Flour: {packageFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");

        }
    }
}
