using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceStrawberryPerKg = double.Parse(Console.ReadLine());
            double priceBerryPerKg = priceStrawberryPerKg * 0.50;
            double priceOrangePerKg = priceBerryPerKg -(priceBerryPerKg* 0.40);
            double priceBananaPerKg = priceBerryPerKg - (0.8 * priceBerryPerKg);

            double quantityBanana = double.Parse(Console.ReadLine()) * priceBananaPerKg;
            double quantityOrange = double.Parse(Console.ReadLine()) * priceOrangePerKg;
            double quantityBerry = double.Parse(Console.ReadLine()) * priceBerryPerKg;
            double quantityStrawberry = double.Parse(Console.ReadLine()) * priceStrawberryPerKg;

            double totalSum = quantityStrawberry + quantityOrange + quantityBerry + quantityBanana;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
