using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQuantityFood = int.Parse(Console.ReadLine()) * 1000;
            string command = string.Empty;
            int eatenFood = 0;
            while ((command = Console.ReadLine()) != "Adopted")
            {
                 eatenFood += int.Parse(command);
            }
            if (totalQuantityFood >= eatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalQuantityFood - eatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {eatenFood - totalQuantityFood} grams more.");
            }
        }
    }
}
