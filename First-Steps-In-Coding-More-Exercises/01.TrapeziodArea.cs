using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           
            double result = (b1 + b2) * height /2;
            string formattedResult = result.ToString("F2");
            Console.WriteLine(formattedResult); 
            

        }
    }
}
