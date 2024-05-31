using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            var minutesPerDay = int.Parse(Console.ReadLine());
            var countWalksPerDay = int.Parse(Console.ReadLine());
            var calorieIntake = int.Parse(Console.ReadLine());

            //calculations
            var totalWalkTime = minutesPerDay * countWalksPerDay;
            var totalCalories = totalWalkTime * 5;
            var percentCalories = calorieIntake * 0.50;
            if (totalCalories >= percentCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalories}.");
            }

        }
    }
}
