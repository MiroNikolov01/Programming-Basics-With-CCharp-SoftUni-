using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string projection = Console.ReadLine();
            string packet = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());
            double priceTicket = 0.0;

            if (projection == "John Wick")
            {
                switch (packet)
                {
                    case "Drink": priceTicket = countTickets * 12;
                        break;
                    case "Popcorn":  priceTicket = countTickets * 15;
                        break;
                    case "Menu": priceTicket = countTickets * 19;
                        break;
                }
            }
            else if (projection == "Star Wars")
            {
                switch (packet)
                {
                    case "Drink": priceTicket = countTickets * 18;
                        break;
                    case "Popcorn": priceTicket = countTickets * 25;
                        break;
                    case "Menu": priceTicket = countTickets * 30;
                        break;
                }
            }
            else
            {
                switch (packet)
                {
                    case "Drink": priceTicket = countTickets * 9;
                        break;
                    case "Popcorn": priceTicket = countTickets * 11;
                        break;
                    case "Menu": priceTicket = countTickets * 14;
                        break;
                }
            }
            if (projection == "Star Wars" && countTickets >= 4)
            {
                priceTicket *= 0.70;
            }
            else if (projection == "Jumanji" && countTickets == 2)
            {
                priceTicket *= 0.85;
            }
            Console.WriteLine($"Your bill is {priceTicket:F2} leva.");
        }
    }
}
