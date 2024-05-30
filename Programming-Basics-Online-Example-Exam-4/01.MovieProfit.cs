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
            
            string nameFilm = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());
            int countTickets = int.Parse(Console.ReadLine());
            double priceTickets = double.Parse(Console.ReadLine());
            int percentCinema = int.Parse(Console.ReadLine());
            //Calculating the profit from ticket sales 
            double priceTicketDay = countTickets * priceTickets; //price for tickets for one day
            double income = countDays * priceTicketDay; //income from the whole period 
            double percentIncomeCinema = income * percentCinema / 100; //the cinema gets the income
            double incomeFilm = income - percentIncomeCinema; // income from film in leva

            Console.WriteLine($"The profit from the movie {nameFilm} is {incomeFilm:f2} lv.");
        }


    }
}
