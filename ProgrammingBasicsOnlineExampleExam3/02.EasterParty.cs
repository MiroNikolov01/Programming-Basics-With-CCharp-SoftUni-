using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuest = int.Parse(Console.ReadLine());
            double envelopeGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceCake = budget * 0.10;
            if (countGuest >= 10 && countGuest <= 15)
            {
                envelopeGuest *= 0.85;
            }
            else if (countGuest > 15 && countGuest <= 20)
            {
                envelopeGuest *= 0.80;
            }
            else if(countGuest > 20)
            {
                envelopeGuest *= 0.75;
            }
            //For cake 10%
            double totalSum = (countGuest * envelopeGuest) + priceCake;

            if (totalSum <= budget)
            {
                double moneyLeft = Math.Abs(budget - totalSum);
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else if(totalSum > budget)
            {
                double moneyNeed = Math.Abs(totalSum - budget);
                Console.WriteLine($"No party! {moneyNeed:F2} leva needed.");
            }


        }
    }
}
