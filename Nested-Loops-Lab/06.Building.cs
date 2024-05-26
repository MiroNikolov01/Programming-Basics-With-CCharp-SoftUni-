using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            int lastFloor = 0;
            for (int flr = floor; flr >= 1; flr--)
            {
                lastFloor = flr;
                for (int rm = 0; rm < room; rm++)
                {
                    if (floor == lastFloor)
                    {
                        Console.Write($"L{flr}{rm} ");
                    }
                    else if (flr % 2 == 0)
                    {
                        Console.Write($"O{flr}{rm} ");

                    }
                    else
                    {
                        Console.Write($"A{flr}{rm} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
