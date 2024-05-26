using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            double points = 0;
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;
            int invalid = 0;
            int moves = 0;
            for (int i = 0; i < rounds; i++)
            {
                moves = int.Parse(Console.ReadLine());
                if (moves >= 0 && moves <= 9)
                {
                    points += moves * 0.20; r1++;
                }
                else if (moves >= 10 && moves <= 19)
                {
                    points += moves * 0.30;
                    r2++;
                }
                else if (moves >= 20 && moves <= 29)
                {
                    points += moves * 0.40;
                    r3++;
                }
                else if (moves >= 30 && moves <= 39)
                {
                    points += 50;
                    r4++;
                }
                else if (moves >= 40 && moves <= 50)
                {
                    points += 100;
                    r5++;
                }
                else if (moves < 0 || moves > 50)
                {
                    points /= 2;
                    invalid++;
                }
            }
            double percentR1 = (double)r1 / rounds * 100;
            double percentR2 = (double)r2 / rounds * 100;
            double percentR3 = (double)r3 / rounds * 100;
            double percentR4 = (double)r4 / rounds * 100;
            double percentR5 = (double)r5 / rounds * 100;
            double percentInvalid = (double)invalid / rounds * 100;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {percentR1:F2}%");
            Console.WriteLine($"From 10 to 19: {percentR2:f2}%");
            Console.WriteLine($"From 20 to 29: {percentR3:f2}%");
            Console.WriteLine($"From 30 to 39: {percentR4:F2}%");
            Console.WriteLine($"From 40 to 50: {percentR5:F2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");


        }
    }
}
