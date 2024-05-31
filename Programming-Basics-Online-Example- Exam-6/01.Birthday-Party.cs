using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var rentHall = double.Parse(Console.ReadLine());

            var priceCake = rentHall * 0.20;
            var priceDrinks = priceCake - (priceCake * 0.45);
            var priceAnimator = rentHall / 3;

            var totalPrice = rentHall + priceCake + priceDrinks + priceAnimator;
            Console.WriteLine($"{totalPrice:f1}");
        }
    }
}
