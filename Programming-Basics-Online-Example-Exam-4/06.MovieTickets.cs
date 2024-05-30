using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int symbol1 = a1; symbol1 <= a2 - 1; symbol1++)
            {
                char character = (char)symbol1;
                for (int symbol2 = 1; symbol2 <= n - 1; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= (n / 2 - 1); symbol3++)
                    {
                        if (symbol1 % 2 == 1 && (symbol2 + symbol3 + symbol1) % 2 == 1)
                        {
                            Console.WriteLine($"{character}-{symbol2}{symbol3}{symbol1}");
                        }
                    }
                }
            }
        }
    }
}


