using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        { 

            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int countPeople = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            //prices
            double vipTicket = 499.99;
            double normTicket = 249.99;
            switch (category) 
            {
                case "VIP":
                    totalPrice = countPeople * vipTicket;
                    if (countPeople >= 1 && countPeople <= 4)
                    {
                        budget *= 0.25;
                    }
                    else if (countPeople >= 5 && countPeople <= 9)
                    {
                        budget *= 0.40;
                    }
                    else if (countPeople >= 10 && countPeople <= 24)
                    {
                        budget *= 0.50;
                    }
                    else if (countPeople >= 25 && countPeople <= 49)
                    {
                        budget *= 0.60;
                    }
                    else if (countPeople >= 50)
                    {
                        budget *= 0.75;
                    }
                    break;
                case "Normal":
                    totalPrice = countPeople * normTicket;
                    if (countPeople >= 1 && countPeople <= 4)
                    {
                        budget *= 0.25;
                    }
                    else if (countPeople >= 5 && countPeople <= 9)
                    {
                        budget *= 0.40;
                    }
                    else if (countPeople >= 10 && countPeople <= 24)
                    {
                        budget *= 0.50;
                    }
                    else if (countPeople >= 25 && countPeople <= 49)
                    {
                        budget *= 0.60;
                    }
                    else if (countPeople >= 50)
                    {
                        budget *= 0.75;
                    }
                    break;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = Math.Abs(budget - totalPrice);
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = Math.Abs(budget - totalPrice);
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
