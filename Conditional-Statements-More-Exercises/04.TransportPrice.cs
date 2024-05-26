using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kms = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double taxi;

            if (dayTime == "day")
            {
                taxi = 0.70 + kms * 0.79;
            }
            else if (dayTime == "night")
            {
                taxi = 0.70 + kms * 0.90;
            }
            else
            {
                Console.WriteLine("Incorrect form day/night");
                return;
            }

            double train = kms * 0.06;
            double bus = kms * 0.09;
            //---

            double best = taxi;

            if (kms >= 20 && kms < 100)
            {
                if (bus < taxi)
                {
                    best = bus;
                }
            }
            else if (kms >= 100)
            {
                if (bus <= taxi && bus <= train)
                {
                    best = bus;
                }
                else
                {
                    best = train;
                }
            }

            Console.WriteLine($"{best:f2}");
        }
    }
}

