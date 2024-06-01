using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageOver20Kg = double.Parse (Console.ReadLine()); //price for luggage
            double luggageKg = double.Parse(Console.ReadLine());
            int timeUntilTravel = int.Parse(Console.ReadLine());
            int countLuggage = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            if (luggageKg < 10)
            {
                totalPrice = luggageOver20Kg * 0.20;
            }
            else if (luggageKg >= 10 && luggageKg <= 20)
            {
                totalPrice = luggageOver20Kg * 0.50;
            }
            else if (luggageKg > 20)
            {
                totalPrice = luggageOver20Kg;
            }
            if (timeUntilTravel > 30)
            {
                totalPrice *= 1.10;
            }
            else if (timeUntilTravel>=7 && timeUntilTravel <= 30)
            {
                totalPrice *= 1.15;
            }
            else
            {
                totalPrice *= 1.40;
            }
            Console.WriteLine($"The total price of bags is: {countLuggage * totalPrice:F2} lv. ");

        }
    }
}
