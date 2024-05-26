using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string stay = string.Empty;
            string destination = string.Empty;
            
            if (budget <= 100)
            {
                    destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        budget *= 0.30;
                        stay = "Camp";
                        break;
                    case "winter":
                        budget *= 0.70;
                        stay = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        budget *= 0.40;
                        stay = "Camp";
                        break;
                    case "winter":
                        budget *= 0.80;
                        stay = "Hotel";
                        break;
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                stay = "Hotel";
                budget *= 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stay} - {budget:f2}");

        }
    }
}
