using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            isFound = false;
                            if ((a + b + c + d) == (a * b * c * d) && n % 10 == 5)
                            {
                                isFound = true;
                                Console.WriteLine($"{a}{b}{c}{d}");
                                return;
                            }
                            else if ((int)(a * b * c * d) / (int)(a + b + c + d) == 3 && n % 3 == 0)
                            {
                                isFound = true;
                                Console.WriteLine($"{d}{c}{b}{a}");
                                return;
                            }
                           
                           
                        }
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("Nothing found");
            }
        }
    }
}
