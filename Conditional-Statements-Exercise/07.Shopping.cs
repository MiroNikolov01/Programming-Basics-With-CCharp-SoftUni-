using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double peterBudget = double.Parse(Console.ReadLine());
            int graphicCard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int priceForGraphicCard = graphicCard * 250;
            double priceForProcessor = processor* (priceForGraphicCard - priceForGraphicCard * 0.65);
            double priceForRam = ram *(priceForGraphicCard - priceForGraphicCard * 0.90);
            double totalSum = priceForGraphicCard + priceForProcessor + priceForRam;
         
            if (graphicCard > processor)
            {
                totalSum *= 0.85;
            }
            if (totalSum <= peterBudget)
            {
                double moneyLeft = Math.Abs(peterBudget - totalSum);
                Console.WriteLine($"You have {moneyLeft:F2} leva left!");
            }
            else
            {
                double moneyNeeded = Math.Abs(totalSum - peterBudget);
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
           
        }
    }
}
