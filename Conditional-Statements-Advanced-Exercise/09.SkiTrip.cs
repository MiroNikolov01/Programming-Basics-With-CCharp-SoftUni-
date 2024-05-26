using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int relaxDays = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double finalPrice = relaxDays - 1;
            relaxDays = relaxDays - 1;
            switch (roomType)
            {
                case "room for one person":
                    finalPrice *= 18;
                    break;
                case "apartment":
                    finalPrice *= 25;
                    if (relaxDays < 10)
                    {
                        finalPrice *= 0.70;
                    }
                    else if (relaxDays >= 10 && relaxDays <= 15)
                    {
                        finalPrice *= 0.65;
                    }
                    else
                    {
                        finalPrice *= 0.50;
                    }
                    break;
                case "president apartment":
                    finalPrice *= 35;
                    if (relaxDays < 10)
                    {
                        finalPrice *= 0.90;
                    }
                    else if (relaxDays >= 10 && relaxDays <= 15)
                    {
                        finalPrice *= 0.85;
                    }
                    else
                    {
                        finalPrice *= 0.80;
                    }
                    break;
            }
            if (rating == "positive")
            {
                finalPrice *= 1.25;
            }
            else
            {
                finalPrice *= 0.90;
            }
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
