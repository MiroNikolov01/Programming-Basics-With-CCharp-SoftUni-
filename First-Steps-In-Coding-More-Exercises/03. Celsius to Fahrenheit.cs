using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            double farenheit = degrees * 9 / 5 + 32;
            string formattedResult = farenheit.ToString("F2");
            Console.WriteLine(formattedResult);



          
        }
    }
}
