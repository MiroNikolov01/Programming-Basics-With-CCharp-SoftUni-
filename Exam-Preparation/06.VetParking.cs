using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursForDay = int.Parse(Console.ReadLine());
            double Sum = 0;
            double totalSum = 0;
            for (int i = 1; i <= days; i++)
            {
                Sum = 0;
                for (int y = 1; y <= hoursForDay; y++)
                {
                    if (i % 2 ==0 && y % 2 == 1)
                    {
                        Sum += 2.50;
                    }
                    else if (i % 2 == 1 && y % 2 == 0)
                    {
                        Sum += 1.25;
                    }
                    else
                    {
                        Sum++;
                    }
                }
                        totalSum += Sum;
                    Console.WriteLine($"Day: {i} – {Sum:F2} leva");
            }
            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}
