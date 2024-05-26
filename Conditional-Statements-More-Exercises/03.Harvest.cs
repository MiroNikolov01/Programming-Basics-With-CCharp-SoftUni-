using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineYard = int.Parse(Console.ReadLine());
            double grapeForOneMeter = double.Parse(Console.ReadLine());
            int neededLitresWine = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());

            double totalGrape = vineYard * grapeForOneMeter;
            double totalWine = 0.40 *( totalGrape  / 2.5);
            double wineLeft = (totalWine - neededLitresWine);
            double partForWorkers = wineLeft / countWorkers;

            if (totalWine >= neededLitresWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(partForWorkers)} liters per person.");
            }
            else
            {
                double wineNeeded = (neededLitresWine - totalWine);
                Console.WriteLine($"It will be a tough winter! More {(Math.Floor(wineNeeded))} liters wine needed.");

            }
        }
    }
}
