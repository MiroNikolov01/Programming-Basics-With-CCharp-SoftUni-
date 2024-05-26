using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "NoMoreMoney")
            {
            double input = double.Parse(command);

                if (input < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += input;
                Console.WriteLine($"Increase: {input:f2}");
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
