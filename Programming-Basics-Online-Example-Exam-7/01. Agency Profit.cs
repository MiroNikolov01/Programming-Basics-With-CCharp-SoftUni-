using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            var countAdult = int.Parse(Console.ReadLine());
            var countKids = int.Parse(Console.ReadLine());
            var priceTicket = double.Parse(Console.ReadLine());
            var priceServing = double.Parse(Console.ReadLine());

            var priceTicketKid = (priceTicket * 0.30) + priceServing;
            var priceAdult = priceTicket + priceServing;
            var totalPrice = (countAdult * priceAdult) + (countKids * priceTicketKid);
            var total = totalPrice * 0.20;
            Console.WriteLine($"The profit of your agency from {company} tickets is {total:F2} lv.");
        }
    }
}
