using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            //flour
            double flourPriceKg = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            //sugar
            double sugarKg = double.Parse(Console.ReadLine());
            //eggs
            int cartonEggs = int.Parse(Console.ReadLine());
            //yeast
            int packageYeast = int.Parse(Console.ReadLine());

            double priceSugar = flourPriceKg * 0.75;
            double priceCartonEgg = flourPriceKg * 1.1;
            double priceYeast = priceSugar * 0.20;

            double sumFlour = flourPriceKg * flourKg;
            double sumSugar = priceSugar * sugarKg;
            double sumEggs = priceCartonEgg * cartonEggs;
            double sumYeast = priceYeast * packageYeast;

            double totalSum = sumFlour + sumSugar + sumEggs + sumYeast;
            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
