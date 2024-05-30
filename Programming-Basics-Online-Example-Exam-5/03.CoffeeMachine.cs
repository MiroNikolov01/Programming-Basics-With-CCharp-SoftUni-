using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var drink = Console.ReadLine();
            var sugar = Console.ReadLine();
            var countDrinks = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            if (drink == "Espresso")
            {
                switch (sugar)
                {
                    case "Without":
                        totalPrice = countDrinks * 0.90;
                        totalPrice *= 0.65;
                        break;
                    case "Normal":
                        totalPrice = countDrinks * 1;
                        break;
                    case "Extra":
                        totalPrice = countDrinks * 1.20;
                        break;
                }
                if (countDrinks >= 5)
                {
                    totalPrice *= 0.75;
                }

            }
            if (drink == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without":
                        totalPrice = countDrinks * 1;
                        totalPrice *= 0.65;
                        break;
                    case "Normal":
                        totalPrice = countDrinks * 1.20;
                        break;
                    case "Extra":
                        totalPrice = countDrinks * 1.60;
                        break;
                }
            }
            if (drink == "Tea")
            {
                switch (sugar)
                {
                    case "Without":
                        totalPrice = countDrinks * 0.50;
                        totalPrice *= 0.65;
                        break;
                    case "Normal":
                        totalPrice = countDrinks * 0.60;
                        break;
                    case "Extra":
                        totalPrice = countDrinks * 0.70;
                        break;
                }
            }
            if (totalPrice > 15)
            {
                totalPrice *= 0.80;
            }
            Console.WriteLine($"You bought {countDrinks} cups of {drink} for {totalPrice:F2} lv.");
        }
    }
}
