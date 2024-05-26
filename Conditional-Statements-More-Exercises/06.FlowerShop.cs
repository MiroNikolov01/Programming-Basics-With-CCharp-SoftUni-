using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnol = int.Parse(Console.ReadLine());
            int zumbul = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double totalSum = magnol * 3.25 + zumbul * 4 + rose * 3.50 + cactus * 8;
            double tax = totalSum * 0.95;
            if (priceGift<=tax)
            {
            double moneyNeeded = Math.Ceiling(priceGift - tax);
                Console.WriteLine($"She is left with {Math.Abs(moneyNeeded)} leva.");
            }
            else
            {
                double moneyLeft = Math.Floor(tax - priceGift);
                Console.WriteLine($"She will have to borrow {Math.Abs(moneyLeft)} leva.");
            }


            

        }
    }
}
