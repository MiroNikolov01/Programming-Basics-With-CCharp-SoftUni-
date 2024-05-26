using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
                                                             
            long budget = long.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFisherman = int.Parse(Console.ReadLine());
           
            double rent = 0.0; 
            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer")
            {
                rent = 4200;
            }
            else if (season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }
            if (countFisherman <= 6)
            {
                rent *= 0.90;
            }
            else if (countFisherman >= 7 && countFisherman <= 11)
            {
                rent *= 0.85;
            }
            else 
            {
                rent *= 0.75;
            }
            if (countFisherman % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }
            if (budget < rent)
            {
                double neededSum = (rent - budget);
                Console.WriteLine($"Not enough money! You need {neededSum:f2} leva.");
            }
            else if(budget >= rent)
            {
                double moneyLeft = (budget - rent);
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
        }
    }
}
