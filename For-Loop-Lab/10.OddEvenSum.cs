using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int evenNum = 0;
            int oddNum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNum += number;
                }
                else
                {
                    oddNum += number;
                }
            }
            if (evenNum == oddNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNum}");
            }
            else
            {
                int diff = Math.Abs(evenNum - oddNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
