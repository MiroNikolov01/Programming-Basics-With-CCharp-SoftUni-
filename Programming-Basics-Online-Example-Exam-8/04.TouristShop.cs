using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameOfProduct = string.Empty;
            double totalSum = 0.0;
            int countBoughtProducts = 0;
            int day = 0;
            while ((nameOfProduct = Console.ReadLine()) != "Stop")
            {
                day++;
            double priceProduct = double.Parse(Console.ReadLine());
                if (day % 3 == 0)
                {
                    priceProduct *= 0.50;
                }
                if (priceProduct > budget)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {priceProduct - budget:F2} leva!"); Environment.Exit(0);
                }
                budget -= priceProduct;
                countBoughtProducts++;
                totalSum += priceProduct;
            }
            if (nameOfProduct == "Stop")
            {
                Console.WriteLine($"You bought {countBoughtProducts} products for {totalSum:F2} leva.");
            }
        }
    }
}
