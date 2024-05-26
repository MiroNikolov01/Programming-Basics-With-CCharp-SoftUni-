using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int dishCleanerBottles = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int cleaner = dishCleanerBottles * 750; //total mililitres
            int plates = 0;
            int pots = 0;
            int totalMililitres = 0;
            int lastCheck = 0;
            int load = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                lastCheck = cleaner;
                load++;
                int dishes = int.Parse(command);
                if (load % 3 == 0)
                {
                    totalMililitres = dishes * 15;
                    pots += dishes;
                    cleaner -= totalMililitres;
                }
                else
                {
                    totalMililitres = dishes * 5;
                    plates += dishes;
                    cleaner -= totalMililitres;
                }
                if (cleaner < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalMililitres - lastCheck)} ml. more necessary!");
                    return;
                }
            }
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {Math.Abs(cleaner)} ml.");
            }

        }
    }

