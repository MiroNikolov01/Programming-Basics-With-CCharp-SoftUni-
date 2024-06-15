using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceVideoCard = int.Parse(Console.ReadLine()) * 13;
            int priceTransition = int.Parse(Console.ReadLine()) * 13;
            double priceConsumation = double.Parse(Console.ReadLine());
            double profitFromCardDay = double.Parse(Console.ReadLine());

            double totalMoneySpend = priceVideoCard + priceTransition + 1000;
            double dayProfit = profitFromCardDay - priceConsumation;
            double totalProfitForCards = 13 * dayProfit;
            double returnDays = Math.Ceiling(totalMoneySpend / totalProfitForCards);

            Console.WriteLine($"{totalMoneySpend}\n{returnDays}");

        }
    }
}
