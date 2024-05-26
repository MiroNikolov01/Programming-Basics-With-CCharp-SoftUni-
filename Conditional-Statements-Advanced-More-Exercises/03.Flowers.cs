using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();

            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumPrice = 2.00;
                rosePrice = 4.10;
                tulipPrice = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumPrice = 3.75;
                rosePrice = 4.50;
                tulipPrice = 4.15;
            }

            double totalPrice = chrysanthemums * chrysanthemumPrice + rose * rosePrice + tulip * tulipPrice;

            if (isHoliday == "Y")
            {
                totalPrice *= 1.15;
            }

            if (season == "Spring" && tulip > 7)
            {
                totalPrice *= 0.95;
            }

            if (season == "Winter" && rose >= 10)
            {
                totalPrice *= 0.90;
            }

            int totalFlowers = chrysanthemums + rose + tulip;

            if (totalFlowers > 20)
            {
                totalPrice *= 0.80;
            }

            totalPrice += 2; 

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}