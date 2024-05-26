using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colouns = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (movieType == "Premiere")
            {
                price = rows * colouns * 12.00;
            }
            else if (movieType == "Normal")
            {
                price = rows * colouns * 7.50;
            }
            else
            {
                price = rows * colouns * 5.00;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
