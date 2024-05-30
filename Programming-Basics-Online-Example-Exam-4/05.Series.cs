using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;
            for (int i = 1; i <= n; i++)
            {
                string series = Console.ReadLine();
                decimal priceSeries = decimal.Parse(Console.ReadLine());
                switch (series)
                {
                    case "Thrones": totalPrice += priceSeries * 0.50m; break;
                    case "Lucifer": totalPrice += priceSeries * 0.60m; break;
                    case "Protector": totalPrice += priceSeries * 0.70m; break;
                    case "TotalDrama": totalPrice += priceSeries * 0.80m; break;
                    case "Area": totalPrice += priceSeries * 0.90m; break;
                    default: totalPrice += priceSeries; break; 

                }
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalPrice:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalPrice - budget:F2} lv. more to buy the series!");
            }
        }
    }
}
