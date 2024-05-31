using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double backCapacity = double.Parse(Console.ReadLine());
            int day = 0;
            int countLoad = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                day++;
                double volumeLuggage = double.Parse(command);
                if (day % 3 == 0)
                {
                    volumeLuggage *= 1.1;
                }
                if (volumeLuggage > backCapacity)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                backCapacity -= volumeLuggage;
                countLoad++;
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {countLoad} suitcases loaded.");
            
        }
    }
}
