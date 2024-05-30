using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int cartonEggs = int.Parse(Console.ReadLine());
            int pastryKg = int.Parse(Console.ReadLine());

            double priceBread = easterBread * 3.20;
            double priceEggs = cartonEggs * 4.35;
            double pricePastry = pastryKg * 5.40;
            double priceEggPaint = cartonEggs * 12 * 0.15;

            double totalPrice = priceBread + priceEggs + pricePastry + priceEggPaint;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
