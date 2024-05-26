using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
           
            string evenOrOdd = string.Empty;
           
            if (operation == '+')
            {
                  int result = num1 + num2;
                if (result % 2 == 0)
                {
                     evenOrOdd = "even";
                }
                else
                {
                     evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} + {num2} = {result} - {evenOrOdd}");
            }
            else if (operation == '-')
            {
                 int result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} - {num2} = {result} - {evenOrOdd}");
            }
            else if (operation == '*')
            {
                int result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} * {num2} = {result} - {evenOrOdd}");
            }
            else if (operation == '/')
            {
                double result = (double)num1 / num2;
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
            }
            else if (operation == '%')
            {
                if (num2 != 0)
                {
                double result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
        }
    }
}
