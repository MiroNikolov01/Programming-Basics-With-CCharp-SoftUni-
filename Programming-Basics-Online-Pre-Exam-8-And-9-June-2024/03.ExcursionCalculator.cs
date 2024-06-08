using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalPrice = 0;
            if (countPeople <= 5)
            {
                switch (season)
                {
                    case "spring": totalPrice = 50; break;
                    case "summer": totalPrice = 48.50; totalPrice *= 0.85; break;
                    case "autumn": totalPrice = 60; break;
                    case "winter": totalPrice = 86; totalPrice *= 1.08; break;
                }
            }
            else if (countPeople > 5)
            {
                switch (season)
                {
                    case "spring": totalPrice = 48; break;
                    case "summer": totalPrice = 45; totalPrice *= 0.85; break;
                    case "autumn": totalPrice = 49.50; break;
                    case "winter": totalPrice = 85; totalPrice *= 1.08; break;
                }
            }
            totalPrice *= countPeople;
            Console.WriteLine($"{totalPrice:F2} leva.");
        }
    }
}
