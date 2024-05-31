using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySum = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var sport = Console.ReadLine();
            var priceCard = 0.0;

            switch (gender)
            {
                case "m":
                    switch (sport)
                    {
                        case "Gym": priceCard = 42; break;
                        case "Boxing": priceCard = 41; break;
                        case "Yoga": priceCard = 45; break;
                        case "Zumba": priceCard = 34; break;
                        case "Dances": priceCard = 51; break;
                        case "Pilates": priceCard = 39; break;
                    }
                    break;
                case "f":
                    switch (sport)
                    {
                        case "Gym": priceCard = 35; break;
                        case "Boxing": priceCard = 37; break;
                        case "Yoga": priceCard = 42; break;
                        case "Zumba": priceCard = 31; break;
                        case "Dances": priceCard = 53; break;
                        case "Pilates": priceCard = 37; break;
                    }
                    break;
            }
            if (age <= 19) priceCard *= 0.80;
            
            if (mySum >= priceCard)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");

            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${priceCard - mySum:f2} more.");
            }
                
        }
    }
}
