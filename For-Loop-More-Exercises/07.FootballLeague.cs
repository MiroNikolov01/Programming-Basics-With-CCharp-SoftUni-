using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int allFans = int.Parse(Console.ReadLine());
            double countA = 0.0;
            double countB = 0.0;
            double countV = 0.0;
            double countG = 0.0;
            for (int i = 0; i < allFans; i++)
            {
                var sector = Console.ReadLine();
                switch (sector)
                {
                    case "A": countA++; break;
                    case "B": countB++; break;
                    case "V": countV++; break;
                    case "G": countG++; break;
                }
            }
            double percentA = countA / allFans*100;
            double percentB = countB / allFans*100;
            double percentV = countV / allFans*100;
            double percentG = countG / allFans*100;
            double avaragePercent = (double)allFans / stadiumCapacity * 100;

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{avaragePercent:f2}%");
        }
    }
}
