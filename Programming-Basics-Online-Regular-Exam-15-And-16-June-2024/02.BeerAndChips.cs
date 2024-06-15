using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double totalPriceBeer = double.Parse(Console.ReadLine()) * 1.20;
            int countChips = int.Parse(Console.ReadLine());

            double priceOneChips = totalPriceBeer * 0.45;
            double totalPriceChips = Math.Ceiling(priceOneChips * countChips);
            double totalPrice = totalPriceBeer + totalPriceChips;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"{playerName} bought a snack and has {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{playerName} needs {totalPrice - budget:F2} more leva!");
            }

        }
    }
}
