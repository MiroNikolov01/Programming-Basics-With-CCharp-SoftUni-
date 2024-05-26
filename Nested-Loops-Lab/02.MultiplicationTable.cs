using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num1 = 1; num1 <= 10; num1++)
            {
                for (int num2 = 1; num2 <= 10; num2++)
                {
                    int result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                }
            }
        }
    }
}
