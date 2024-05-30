using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());
            double finalPrice = 0.0;
            if (filmName == "A Star Is Born")
            {
                switch (hallType)
                {
                    case "normal":
                        finalPrice = countTickets * 7.50;
                        break;
                    case "luxury":
                        finalPrice = countTickets * 10.50;
                        break;
                    case "ultra luxury":
                        finalPrice = countTickets * 13.50;
                        break;

                }
            }
            else if (filmName == "Bohemian Rhapsody")
            {
                switch (hallType)
                {
                    case "normal":
                        finalPrice = countTickets * 7.35;
                        break;
                    case "luxury":
                        finalPrice = countTickets * 9.45;
                        break;
                    case "ultra luxury":
                        finalPrice = countTickets * 12.75;
                        break;
                }
            }
            else if (filmName == "Green Book")
            {
                switch (hallType)
                {
                    case "normal":
                        finalPrice = countTickets * 8.15;
                        break;
                    case "luxury":
                        finalPrice = countTickets * 10.25;
                        break;
                    case "ultra luxury":
                        finalPrice = countTickets * 13.25;
                        break;
                }
            }
            else if (filmName == "The Favourite")
            {
                switch (hallType)
                {
                    case "normal":
                        finalPrice = countTickets * 8.75;
                        break;
                    case "luxury":
                        finalPrice = countTickets * 11.55;
                        break;
                    case "ultra luxury":
                        finalPrice = countTickets * 13.95;
                        break;
                }
            }
            Console.WriteLine($"{filmName} -> {finalPrice:f2} lv.");
        }
    }
}
