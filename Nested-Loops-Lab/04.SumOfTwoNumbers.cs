using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int totalCounter = 0;
            int notEquals = 0;
            for (int x = start; x <=end ; x++)
            {
                for (int y = start; y <= end; y++)
                {
                totalCounter++;
                    if (x + y == magicNum)
                    {
                        Console.WriteLine($"Combination N:{totalCounter} ({x} + {y} = {magicNum})"); Environment.Exit(0);
                    }
                    if (x + y != magicNum)
                    {
                        notEquals++;
                    }
                }
            }
            Console.WriteLine($"{notEquals} combinations - neither equals {magicNum}");

        }
    }
}
