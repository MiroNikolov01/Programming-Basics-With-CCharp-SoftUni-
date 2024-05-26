using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double sumAny = 0;
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                while (sumAny <= budget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    sumAny += sum;
                    if (sumAny >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        sumAny = 0;
                        break;
                    }

                }
                        destination = Console.ReadLine();
            }

        }
    }
}


