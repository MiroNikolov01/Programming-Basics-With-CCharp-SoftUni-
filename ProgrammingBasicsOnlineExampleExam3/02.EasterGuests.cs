using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());


            double countEasterBread = (double)countGuests / 3;
            double EasterBread = Math.Ceiling(countEasterBread);
             
           
            double countEggs = countGuests * 2;

            double priceEasterBread = EasterBread * 4;
            double priceEggs = countEggs * 0.45;

            double totalPrice = priceEasterBread + priceEggs;

            double moneyLeft = Math.Abs(budget - totalPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Lyubo bought {EasterBread} Easter bread and {countEggs} eggs.");
                Console.WriteLine($"He has {moneyLeft:F2} lv. left.");
            }
            else
            {
                double moneyNeeded = Math.Abs(totalPrice - budget);
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded:F2} lv. more.");
            }



        }
    }
}
