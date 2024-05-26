using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //WORK IN PROGRESS!!!!!
            string food = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            if (day == "Saturday" || day == "Sunday")
            {
                switch (food)
                {
                    case "banana":
                        amount *= 2.70;
                        break;
                    case "apple":
                        amount *= 1.25;
                        break;
                    case "orange":
                        amount *= 0.90;
                        break;
                    case "grapefruit":
                        amount *= 1.60;
                        break;
                    case "kiwi":
                        amount *= 3.00;
                        break;
                    case "pineapple":
                        amount *= 5.60;
                        break;
                    case "grapes":
                        amount *= 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {

                switch (food)
                {
                    case "banana":
                        amount *= 2.50;
                        break;
                    case "apple":
                        amount *= 1.20;
                        break;
                    case "orange":
                        amount *= 0.85;
                        break;
                    case "grapefruit":
                        amount *= 1.45;
                        break;
                    case "kiwi":
                        amount *= 2.70;
                        break;
                    case "pineapple":
                        amount *= 5.50;
                        break;
                    case "grapes":
                        amount *= 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine($"{amount:f2}");
        }
    }
}