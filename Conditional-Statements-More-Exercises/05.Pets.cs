using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double dogFoodForDay = double.Parse(Console.ReadLine());
            double catFoodForDay = double.Parse(Console.ReadLine());
            double turtleFoodForDay = double.Parse(Console.ReadLine());

            double neededFDog = days * dogFoodForDay;
            double neededFCat = days * catFoodForDay;
            double neededFTurtle = days * turtleFoodForDay /1000;
            double totalFood = neededFDog + neededFCat + neededFTurtle;
            if (totalFood < foodLeftInKg)
            {
                double leftOver = Math.Floor(foodLeftInKg - totalFood);
                Console.WriteLine($"{leftOver} kilos of food left.");
            }
            else
            {
                double neededFood = Math.Ceiling(totalFood - foodLeftInKg);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
