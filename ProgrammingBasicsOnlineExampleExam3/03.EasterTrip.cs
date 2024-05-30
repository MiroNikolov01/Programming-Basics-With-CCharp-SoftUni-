using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string reservasionDate = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            int totalCost = 0;

            switch (destination)
            {
                case "France":
                    if (reservasionDate == "21-23")
                    {
                        totalCost =  countNights * 30;
                    }
                    else if (reservasionDate == "24-27")
                    {
                        totalCost = countNights * 35;
                    }
                    else
                    {
                        totalCost = countNights * 40;
                    }
                    break;
                case "Italy":
                    if (reservasionDate == "21-23")
                    {
                        totalCost = countNights * 28;
                    }
                    else if (reservasionDate == "24-27")
                    {
                        totalCost = countNights * 32;
                    }
                    else
                    {
                        totalCost = countNights * 39;
                    }
                    break;
                case "Germany":
                    if (reservasionDate == "21-23")
                    {
                        totalCost = countNights * 32;
                    }
                    else if (reservasionDate == "24-27")
                    {
                        totalCost = countNights * 37;
                    }
                    else
                    {
                        totalCost = countNights * 43;
                    }
                    break;

            }
                    Console.WriteLine($"Easter trip to {destination} : {totalCost:f2} leva.");

        }
    }
}
