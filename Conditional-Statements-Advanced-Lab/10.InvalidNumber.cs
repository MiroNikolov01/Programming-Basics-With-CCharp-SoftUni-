using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // THE 0 IS THE PROBLEM !!!!90/100
            int num = int.Parse(Console.ReadLine());

            if ((num >= 100 && num <= 200) || (num == 0))
            {
                Console.WriteLine("");
            }
            else 
            {
                Console.WriteLine("invalid");
            }

        }
    }
}