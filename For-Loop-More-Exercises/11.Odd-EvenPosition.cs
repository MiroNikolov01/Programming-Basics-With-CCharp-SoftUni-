using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            // Odd Numbers
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            // Even Numbers
            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (oddMax < number)
                    {
                        oddMax = number;
                    }
                    if (oddMin > number)
                    {
                        oddMin = number;
                    }
                    
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            else { Console.WriteLine($"OddMin=No,"); }

            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else { Console.WriteLine($"OddMax=No,"); }

            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            else { Console.WriteLine($"EvenMin=No,"); }

            if (evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else { Console.WriteLine($"EvenMax=No"); }
        }
        }
    }



