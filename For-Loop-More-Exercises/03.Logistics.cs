using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCargo = int.Parse(Console.ReadLine());

            int totalCargo = 0;
            int bus = 0;
            int truck = 0;
            int train = 0;

            for (int i = 0; i < countCargo; i++)
            {
                int tonCargo = int.Parse(Console.ReadLine());
                totalCargo += tonCargo;
                if (tonCargo <= 3)
                {
                    bus += tonCargo;
                }
                else if (tonCargo >= 4 && tonCargo <= 11)
                {
                    truck += tonCargo;
                }
                else if (tonCargo >= 12)
                {
                    train += tonCargo;
                }
            }
            double percentBus = (double)bus / totalCargo * 100;
            double percentTruck = (double)truck / totalCargo * 100;
            double percentTrain = (double)train / totalCargo * 100;

            double avarageTon = ((double)bus * 200 + truck * 175 + train * 120) / totalCargo;
            Console.WriteLine($"{avarageTon:f2}");
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");

        }
    }
}
