using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            if (fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                double volume = Double.Parse(Console.ReadLine());
                string fuelText = fuel.ToLower();
                if (volume >= 25)
                {
                    Console.WriteLine($"You have enough {fuelText}.");
                }
                else if (volume < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuelText}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}





