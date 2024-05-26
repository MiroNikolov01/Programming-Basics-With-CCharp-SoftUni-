using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (sum >= number)
                {
                    break;
                }
            }
                    Console.WriteLine(sum);
        }
    }
}
