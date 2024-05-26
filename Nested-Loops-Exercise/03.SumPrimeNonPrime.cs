using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumCompostie = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "stop")
            {
                int counterPrimeNumber = 0;
                int num = int.Parse(command);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else
                {
                    if (num < 2)
                    {
                        sumCompostie += num;
                    }
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            counterPrimeNumber++;
                        }
                    }
                    if (counterPrimeNumber == 2)
                    {
                        sumPrime += num;
                    }
                    else
                    {
                        sumCompostie += num;
                    }
                }
            }
                Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
                Console.WriteLine($"Sum of all non prime numbers is: {sumCompostie}");
        }
    }
}


