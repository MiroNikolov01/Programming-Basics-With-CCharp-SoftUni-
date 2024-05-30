using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());
            double priceLounger = double.Parse(Console.ReadLine());
            double priceUmbrella = double.Parse(Console.ReadLine());

            double percentLounger = Math.Ceiling(countPeople * 0.75);
            double percentUmbrella = Math.Ceiling(countPeople * 0.50);

            double totalFee = countPeople * fee;
            double totalPriceUmbrella = percentUmbrella * priceUmbrella;
            double totalPriceLounger = percentLounger * priceLounger;

            double totalPrice = totalFee + totalPriceLounger + totalPriceUmbrella;
            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
