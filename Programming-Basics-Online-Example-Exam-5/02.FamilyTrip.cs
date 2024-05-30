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
            double priceNights = double.Parse(Console.ReadLine());
            int addedPercent = int.Parse(Console.ReadLine());
            if (countNights > 7)
            {
                priceNights *= 0.95;
            }
            double totalPrice = countNights * priceNights;
            double addedPercentBudget = (budget * addedPercent) / 100;
            double totalBudget = totalPrice + addedPercentBudget;
            if (budget >= totalBudget)
            {
                Console.WriteLine($"Ivanovi will be left with {Math.Abs(totalBudget - budget):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(budget - totalBudget):F2} leva needed.");
            }


        }
    }
}
