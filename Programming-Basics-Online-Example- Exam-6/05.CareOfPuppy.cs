using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKG = int.Parse(Console.ReadLine()) * 1000;
            string command = string.Empty;
            int eatenFood = 0;
            while ((command = Console.ReadLine()) != "Adopted")
            {
                int Food = int.Parse(command);
                eatenFood += Food;
            }
            int diff = Math.Abs(foodInKG - eatenFood);
            if(foodInKG >= eatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
        }
    }
}
