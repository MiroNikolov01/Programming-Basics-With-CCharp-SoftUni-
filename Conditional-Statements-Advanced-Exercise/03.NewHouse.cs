using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {  
                                                           
            string flowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            double priceRose = 5;
            double priceDahlias = 3.80;
            double priceTulips = 2.80;
            double priceNarcissus = 3;
            double priceGladiolus = 2.50; 

            if (flowers == "Roses")
            {
                totalPrice = countOfFlowers * priceRose;
                if (countOfFlowers > 80)
                {
                    totalPrice *= 0.90;
                } 
            }
            if (flowers == "Dahlias")
            {
                totalPrice = countOfFlowers * priceDahlias;
                if (countOfFlowers > 90)
                {
                    totalPrice *= 0.85;
                }
            }
            if (flowers == "Tulips")
            {
                totalPrice = countOfFlowers * priceTulips;
                if (countOfFlowers > 80)
                {
                    totalPrice *= 0.85;
                }
            }
            if (flowers == "Narcissus")
            {
                totalPrice = countOfFlowers * priceNarcissus;
                if (countOfFlowers < 120)
                {
                    double increasePercent = (totalPrice * 85) / 100;
                    double percentTotal = totalPrice - increasePercent;
                    totalPrice += percentTotal;
                }
            }
            if (flowers == "Gladiolus")
            {
                totalPrice = countOfFlowers * priceGladiolus;
                if (countOfFlowers < 80)
                {
                    double increasePercent = (totalPrice * 80) / 100;
                    double percentTotal = totalPrice - increasePercent;
                    totalPrice += percentTotal; 
                }
            }
            if (totalPrice > budget)
            {
                double neededSum = (totalPrice - budget);
                Console.WriteLine($"Not enough money, you need {neededSum:F2} leva more.");
            }
            else if (totalPrice <= budget)
            {
                double moneyLeft = (budget - totalPrice);
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowers} and {moneyLeft:F2} leva left.");
            }

        }
    }
}
