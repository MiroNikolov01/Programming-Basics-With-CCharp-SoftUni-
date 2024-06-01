using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            var countJoinery = int.Parse(Console.ReadLine());
            var typeJoinery = Console.ReadLine();
            var typeOfArrival = Console.ReadLine();
            var price = 0.0;
            switch (typeJoinery)
            {
                case "90X130": price = countJoinery * 110;
                   if (countJoinery > 60) price *= 0.92; 
                   else if (countJoinery > 30) price *= 0.95; break;
                case "100X150": price = countJoinery * 140;
                    if (countJoinery > 80) price *= 0.90; 
                    else if (countJoinery > 40) price *= 0.94; break;
                case "130X180": price = countJoinery * 190;
                    if (countJoinery > 50) price *= 0.88;
                    else if (countJoinery > 20) price *= 0.93; break;
                case "200X300": price = countJoinery * 250;
                    if (countJoinery > 50) price *= 0.86; 
                    else if (countJoinery > 25) price *= 0.91; break;
            }
            if (countJoinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            if (typeOfArrival == "With delivery") price += 60;
            if (countJoinery > 99) price *= 0.96;
            Console.WriteLine($"{price:F2} BGN");

        }
    }
}
