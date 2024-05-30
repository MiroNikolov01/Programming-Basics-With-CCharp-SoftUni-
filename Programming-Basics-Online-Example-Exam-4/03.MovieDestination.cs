using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            switch (destination)
            {
                case "Dubai": 
                    if (season == "Winter")
                    {
                        totalPrice = countDays * 45000;
                    }
                    else
                    {
                        totalPrice = countDays * 40000;
                    }
                    totalPrice *= 0.70;
                    break;
                case "Sofia":
                    if (season == "Winter")
                    {
                        totalPrice = countDays * 17000;
                    }
                    else
                    {
                        totalPrice = countDays * 12500;
                    }
                    totalPrice *= 1.25;
                    break;
                case "London":
                    if (season == "Winter")
                    {
                        totalPrice = countDays * 24000;
                    }
                    else
                    {
                        totalPrice = countDays * 20250;
                    }
                    break;
            }
            if (filmBudget >= totalPrice)
            {
            Console.WriteLine($"The budget for the movie is enough! We have {Math.Abs(filmBudget - totalPrice):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(totalPrice - filmBudget):f2} leva more!");
            }

        }
    }
}
