using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Double.TryParse(Console.ReadLine(), out double inp) && inp >= 0)
            {
                double result = inp * 2;

                Console.WriteLine($"Result: {result:F2}");
            }
            Console.WriteLine("Negative number!");
        }
    }
}

    

