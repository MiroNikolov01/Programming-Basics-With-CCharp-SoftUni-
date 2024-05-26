using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutes15 = minutes + 15;
            if (minutes15 >= 60)
            {
                minutes15 = (minutes15) % 60;
                hours = hours + 1;
            }
            if (hours > 23)
            {
                hours = hours % 24;
            }
            if (minutes15 < 10)
            {
                Console.WriteLine($"{hours}:0{minutes15}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes15}");
            }
           


        }
    }
}
