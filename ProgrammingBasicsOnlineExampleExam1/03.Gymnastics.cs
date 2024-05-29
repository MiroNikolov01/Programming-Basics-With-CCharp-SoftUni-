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
            double performance = 0.0;
            switch (applience)
            {
                case "ribbon":
                    if (country == "Russia")
                    {
                        performance = 9.100 + 9.400;
                    }
                    else if (country == "Bulgaria")
                    {
                        performance = 9.600 + 9.400;
                    }
                    else
                    {
                        performance = 9.200 + 9.500;
                    }
                    break;
                case "hoop":
                    if (country == "Russia")
                    {
                        performance = 9.300 + 9.800;
                    }
                    else if (country == "Bulgaria")
                    {
                        performance = 9.550 + 9.750;
                    }
                    else
                    {
                        performance = 9.450 + 9.350;
                    }
                    break;
                case "rope":
                    if (country == "Russia")
                    {
                        performance = 9.600 + 9.000;
                    }
                    else if (country == "Bulgaria")
                    {
                        performance = 9.500 + 9.400;
                    }
                    else
                    {
                        performance = 9.700 + 9.150;
                    }
                    break;
            }
            double maxResultLeft = 20 - performance;
            double percent = (maxResultLeft / 20) * 100;
            Console.WriteLine($"The team of {country} get {performance:f3} on {applience}.");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
