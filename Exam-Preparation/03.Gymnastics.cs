using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string applience = Console.ReadLine();
            double totalRate = 0;
            switch (country)

            {
                case "Russia":
                    switch (applience)
                    {
                        case "ribbon":
                            totalRate += 9.100 + 9.400; break;
                        case "hoop":
                            totalRate += 9.300 + 9.800; break;
                        case "rope":
                            totalRate += 9.600 + 9.000; break;
                    }
                    break;
                case "Bulgaria":
                    switch (applience)
                    {
                        case "ribbon":
                            totalRate += 9.600 + 9.400; break;
                        case "hoop":
                            totalRate += 9.550 + 9.750; break;
                        case "rope":
                            totalRate += 9.500 + 9.400; break;
                    }
                    break;
                case "Italy":
                    switch (applience)
                    {
                        case "ribbon":
                            totalRate += 9.200 + 9.500; break;
                        case "hoop":
                            totalRate += 9.450 + 9.350; break;
                        case "rope":
                            totalRate += 9.700 + 9.150; break;
                    }
                    break;
            }
            double percent = (20 - totalRate) / 20 * 100.0;
            Console.WriteLine($"The team of {country} get {totalRate:F3} on {applience}.");
            Console.WriteLine($"{percent:F2}%");
        }
    }
}
