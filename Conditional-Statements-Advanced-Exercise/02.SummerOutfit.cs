using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (degrees >= 10 && degrees <= 18)
            {
                if (day == "Morning")
                {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
                }
                else if (day == "Afternoon" || day == "Evening")
                {
                outfit = "Shirt";
                shoes = "Moccasins";
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                if (day == "Morning" || day == "Evening")
                {
                outfit = "Shirt";
                shoes = "Moccasins";
                }
                else if (day == "Afternoon")
                {
                outfit = "T-Shirt";
                shoes = "Sandals";
                }
            }
            if (degrees >=25)
            {
                if (day == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (day == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (day == "Evening")
                {
                outfit = "Shirt";
                shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }

        
    }
}
