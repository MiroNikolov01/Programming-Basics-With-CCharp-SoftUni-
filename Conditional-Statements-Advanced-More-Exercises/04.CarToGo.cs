using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass = string.Empty;
            string carType = string.Empty;
            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    budget *= 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    budget *= 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    budget *= 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    budget *= 0.80; 
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                if (season == "Summer" || season == "Winter")
                {
                    carType = "Jeep";
                    budget *= 0.90;
                }
            }
            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {budget:f2}");
        }
    }
}
