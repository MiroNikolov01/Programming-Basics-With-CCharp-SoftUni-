using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum2 = 0;

            int maxdiff = 0;

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int sum1 = number1 + number2;
                if (i > 0)
                {
                    int diff = Math.Abs(sum1 - sum2);
                    if (diff > maxdiff)
                    {
                        maxdiff = diff;
                    }
                }
                    sum2 = sum1;
                }
            if (maxdiff == 0)
                Console.WriteLine($"Yes, value={sum2}");
            else
            {
                Console.WriteLine($"No, maxdiff={maxdiff}");
            }
        }
    }
}


