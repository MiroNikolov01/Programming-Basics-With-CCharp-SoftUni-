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
            int countDays = int.Parse(Console.ReadLine());
            int countHours = int.Parse(Console.ReadLine());
            double fee = 0;
            double totalFee = 0;
            for (int i = 1; i <= countDays; i++)
            {
                totalFee += fee;
                fee = 0;
                for (int y = 1; y <= countHours; y++)
                {
                    if (i % 2 == 0 && y % 2 == 1)
                    {
                        fee += 2.50;
                    }
                    else if (i % 2 == 1 && y % 2 == 0)
                    {
                        fee += 1.25;
                    }
                    else
                    {
                        fee += 1;
                    }
                    
                }
                Console.WriteLine($"Day: {i} - {fee:F2} leva");
            }
                totalFee += fee;
                Console.WriteLine($"Total: {totalFee:F2} leva");
                   
        }
    }
}
