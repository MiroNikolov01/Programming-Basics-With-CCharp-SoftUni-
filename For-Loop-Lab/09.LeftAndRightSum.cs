using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = int.Parse(Console.ReadLine());
                leftSum += sum;
            }
            for (int y = 0; y < n; y++)
            {
                int sum = int.Parse(Console.ReadLine());
                rightSum += sum;

            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
