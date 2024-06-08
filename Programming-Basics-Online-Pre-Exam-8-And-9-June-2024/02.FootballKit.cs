using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceShirt = double.Parse(Console.ReadLine());
            double sumToAchieve = double.Parse(Console.ReadLine());

            double priceShorts = priceShirt * 0.75;
            double priceSocks = priceShorts * 0.20;
            double priceShoes = (priceShorts + priceShirt) * 2;
            double totalSum = priceShirt + priceShoes + priceSocks + priceShorts;
            totalSum *= 0.85;
            if (totalSum >= sumToAchieve)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!\nHis sum is {totalSum:F2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.\nHe needs {sumToAchieve - totalSum:F2} lv. more.");
            }
        }
    }
}
