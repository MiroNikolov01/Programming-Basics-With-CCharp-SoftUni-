using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var h = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var windows = int.Parse(Console.ReadLine());

            //calculations
            string input = Console.ReadLine();

            double walls = h * w * 4;
            double wallsToPaint = Math.Ceiling(walls - (walls * windows / 100));

            while (input != "Tired!")
            {
                double paint = double.Parse(input);

                wallsToPaint -= paint;
                if (wallsToPaint <= 0)
                {
                    break;
                }
                input = Console.ReadLine();

            }

            if (input == "Tired!")
            {
                Console.WriteLine($"{wallsToPaint} quadratic m left.");
            }
            else if (wallsToPaint == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }

            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(wallsToPaint)} l paint left!");
            }

        }
    }
    }

