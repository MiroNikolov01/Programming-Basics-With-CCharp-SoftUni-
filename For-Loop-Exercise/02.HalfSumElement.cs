using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > max)
                {
                    max = number;
                }
                
            }
            int numWithout = sum - max;
            if (numWithout == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {numWithout}");
            }
            else
            {
                int diff = Math.Abs(max - numWithout);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
