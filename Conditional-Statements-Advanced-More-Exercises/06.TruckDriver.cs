using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmforMonth = double.Parse(Console.ReadLine());
            if (kmforMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        kmforMonth *= 0.75;
                        break;
                    case "Summer":
                        kmforMonth *= 0.90;
                        break;
                    case "Winter":
                        kmforMonth *= 1.05;
                        break;
                       }
            }
            else if (kmforMonth > 10000 && kmforMonth <= 20000)
            {
                kmforMonth *= 1.45;
            }

            else if (kmforMonth > 5000 && kmforMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        kmforMonth *= 0.95;
                        break;
                    case "Summer":
                        kmforMonth *= 1.10;
                        break;
                    case "Winter":
                        kmforMonth *= 1.25;
                        break;
                }
            }
            kmforMonth *= 4;
            kmforMonth *= 0.90;
            Console.WriteLine($"{kmforMonth:f2}");
        }
    }
}
