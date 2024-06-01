using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal neededFuel = decimal.Parse(Console.ReadLine());
            string dayOfTheWeak = Console.ReadLine();

            decimal priceFule = neededFuel * 2.10m;
            decimal totalSum = priceFule + 100;
            if (dayOfTheWeak == "Sunday")
            {
                totalSum *= 0.80m;
            }
            else if (dayOfTheWeak == "Saturday")
                totalSum *= 0.90m;
            if (budget >= totalSum)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalSum:F2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalSum - budget:F2} lv.");
            }
        }

    }
}

