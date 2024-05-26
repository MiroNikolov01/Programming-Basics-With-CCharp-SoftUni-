using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        amount *= 0.50;
                        break;
                    case "water":
                        amount *= 0.80;
                        break;
                    case "beer":
                        amount *= 1.20;
                        break;
                    case "sweets":
                         amount *= 1.45;
                        break;
                    case "peanuts":
                        amount *= 1.60;
                        break;
                }

            }
            if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        amount *= 0.40;
                        break;
                    case "water":
                        amount *= 0.70;
                        break;
                    case "beer":
                        amount *= 1.15;
                        break;
                    case "sweets":
                        amount *= 1.30;
                        break;
                    case "peanuts":
                        amount *= 1.50;
                        break;
                }
            }
            if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        amount *= 0.45;
                        break;
                    case "water":
                        amount *= 0.70;
                        break;
                    case "beer":
                        amount *= 1.10;
                        break;
                    case "sweets":
                        amount *= 1.35;
                        break;
                    case "peanuts":
                        amount *= 1.55;
                        break;
                }
            }
            Console.WriteLine(amount);
        }
    }
}