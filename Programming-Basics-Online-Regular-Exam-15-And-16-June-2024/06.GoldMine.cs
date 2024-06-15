using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLocations = int.Parse(Console.ReadLine());
            double totalYield = 0;
            for (int i = 1; i <= countLocations; i++)
            {
            int expectedYield = int.Parse(Console.ReadLine());
            int daysForMining = int.Parse(Console.ReadLine());
                for (int j = 1; j <= daysForMining; j++)
                {
                     totalYield += double.Parse(Console.ReadLine());
                }
                double averageYeild = totalYield / daysForMining;
                totalYield = 0;
                if (averageYeild >= expectedYield)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageYeild:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedYield - averageYeild:F2} gold.");
                }
            }
        }
    }
}
