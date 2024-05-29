using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceTickets = double.Parse(Console.ReadLine());
            int percentCinema = int.Parse(Console.ReadLine());
            //Calculations
            double totalTicketsForDay = tickets * priceTickets;
            double totalTicketPrice = totalTicketsForDay * days;
            double percent = (totalTicketPrice * percentCinema) / 100;
            double finalProfit = totalTicketPrice - percent;

            //Output
            Console.WriteLine($"The profit from the movie {movieName} is {finalProfit:F2} lv.");


        }
    }
}
