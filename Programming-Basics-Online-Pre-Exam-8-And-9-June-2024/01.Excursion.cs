using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            int countCards = int.Parse(Console.ReadLine());
            int countTicketsMuseum = int.Parse(Console.ReadLine());

            double priceNights = countNights * 20;
            double priceCard = countCards * 1.60;
            double priceMuseum = countTicketsMuseum * 6;
            double priceOnePerson = priceNights + priceCard + priceMuseum;
            double totalPrice = priceOnePerson * countPeople;
            totalPrice *= 1.25;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
