using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            string room = string.Empty;
            double totalPriceStudio = 0.0;
            double totalPriceApart = 0.0;
            if (month == "May" || month == "October")
            {
                totalPriceStudio = nights * 50;
                totalPriceApart = nights * 65;
                if (nights > 14)
                {
                    totalPriceStudio *= 0.70;
                    totalPriceApart *= 0.90;
                }
                else if (nights > 7)
                {
                    totalPriceStudio *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                totalPriceStudio = nights * 75.20;
                totalPriceApart = nights * 68.70;
                if (nights > 14)
                {
                    totalPriceStudio *= 0.80;
                    totalPriceApart *= 0.90;
                }
            }
            else
            {
                totalPriceStudio = nights * 76;
                totalPriceApart = nights * 77;
                if (nights > 14)
                {
                    totalPriceApart *= 0.90;
                }
            }
            Console.WriteLine($"Apartment: {totalPriceApart:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }


    }
}

