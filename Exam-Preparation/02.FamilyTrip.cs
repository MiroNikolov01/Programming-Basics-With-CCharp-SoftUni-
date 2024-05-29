using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            int addedPercent = int.Parse(Console.ReadLine());
            if (countNights > 7)
            {
                priceForNight *= 0.95;
            }
            double totalPriceNights = priceForNight * countNights;
            double percent = (budget * addedPercent) / 100;
            double totalPrice = totalPriceNights + percent;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalPrice:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:F2} leva needed.");
            }
        }
    }
}
