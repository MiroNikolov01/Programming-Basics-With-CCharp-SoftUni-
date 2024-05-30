using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededProfit = double.Parse(Console.ReadLine());
            var price = 0.0;
            var totalSum = 0.0;

            var coctail = string.Empty;
            while ((coctail = Console.ReadLine()) != "Party!")
            {
                
                int countCoctails = int.Parse(Console.ReadLine());

                price = coctail.Length * countCoctails;

                if (price % 2 == 1)
                {
                    price *= 0.75;
                }
                totalSum += price;
                if (totalSum >= neededProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

            }
            if (coctail == "Party!")
            {
                double neededSum = neededProfit - totalSum;
                Console.WriteLine($"We need {neededSum:f2} leva more.");
            }
                Console.WriteLine($"Club income - {totalSum:F2} leva.");
        }
    }
}
