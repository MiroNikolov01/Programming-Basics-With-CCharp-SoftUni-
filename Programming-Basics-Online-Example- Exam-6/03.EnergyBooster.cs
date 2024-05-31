using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int countOrders = int.Parse(Console.ReadLine());
            var totalPrice = 0.0;
            switch (fruit)
            {
                case "Watermelon":
                    switch (size)
                    {
                        case "small": totalPrice = 2 * 56; break;
                        case "big": totalPrice = 5 * 28.70; break;
                    }
                    break;
                case "Mango":
                    switch (size)
                    {
                        case "small": totalPrice = 2 * 36.66; break;
                        case "big": totalPrice = 5 * 19.60; break;
                            
                    }
                    break;
                case "Pineapple":
                    switch (size)
                    {
                        case "small": totalPrice = 2 * 42.10; break;
                        case "big": totalPrice = 5 * 24.80; break;
                    }
                    break;
                case "Raspberry":
                    switch (size)
                    {
                        case "small": totalPrice = 2 * 20; break;
                        case "big": totalPrice = 5 * 15.20; break;
                    }
                    break;
            }
            double set = totalPrice * countOrders;
            totalPrice = set;

            if (set >= 400 && set <= 1000) totalPrice *= 0.85;
            else if (set > 1000) totalPrice *= 0.50;
            //output
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
