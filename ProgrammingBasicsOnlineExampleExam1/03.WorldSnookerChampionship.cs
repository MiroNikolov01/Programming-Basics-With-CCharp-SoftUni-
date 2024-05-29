using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());
            char trophyPic = char.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            switch (ticketType)
            {
                case "Standard":
                    if (stage == "Quarter final")
                    {
                        totalPrice = countOfTickets * 55.50;
                    }
                    else if (stage == "Semi final")
                    {
                        totalPrice = countOfTickets * 75.88;
                    }
                    else if (stage == "Final")
                    {
                        totalPrice = countOfTickets * 110.10;
                    }
                    break;
                case "Premium":
                    if (stage == "Quarter final")
                    {
                        totalPrice = countOfTickets * 105.20;
                    }
                    else if (stage == "Semi final")
                    {
                        totalPrice = countOfTickets * 125.22;
                    }
                    else if (stage == "Final")
                    {
                        totalPrice = countOfTickets * 160.66;
                    }
                    break;
                case "VIP":
                    if (stage == "Quarter final")
                    {
                        totalPrice = countOfTickets * 118.90;
                    }
                    else if (stage == "Semi final")
                    {
                        totalPrice = countOfTickets * 300.40;
                    }
                    else if (stage == "Final")
                    {
                        totalPrice = countOfTickets * 400;
                    }
                    break;
            }
            bool isTrue = (totalPrice > 4000);
            if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
            }
            else if (totalPrice > 2500)
            {
                totalPrice *= 0.90;
            }
            if (trophyPic == 'Y' && isTrue == false)
            {
                totalPrice += countOfTickets * 40;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
