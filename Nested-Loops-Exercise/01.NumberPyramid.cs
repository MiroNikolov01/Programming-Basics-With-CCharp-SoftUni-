using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isTrue = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isTrue = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isTrue)
                {
                    break;
                }
                Console.WriteLine();

            }
        }
    }
}


