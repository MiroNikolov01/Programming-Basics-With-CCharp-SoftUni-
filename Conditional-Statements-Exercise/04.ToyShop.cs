using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVacation = double.Parse(Console.ReadLine());
            int countPuzzle = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalToys = countPuzzle + talkingDolls + teddyBears + minions + trucks;

            double fee = countPuzzle * 2.60 + talkingDolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            if (totalToys >= 50)
            {
                fee *= 0.75;
            }

            double rent = fee * 0.1;
            double profit = fee - rent;

            if (profit >= priceVacation)
            {
                double moneyLeft = profit - priceVacation;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyNeeded = priceVacation - profit;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}