using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string stay = string.Empty;
            string location = string.Empty;
            if (budget <= 1000)
            {
                stay = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.45;
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                stay = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.60;
                        break;
                }
            }
            else if (budget > 3000)
            {
                stay = "Hotel";
                budget *= 0.90;
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;

                }
            }
            Console.WriteLine($"{location} - {stay} - {budget:F2}");
        }
    }
}
