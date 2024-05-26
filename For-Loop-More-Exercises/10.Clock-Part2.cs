using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Clock_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                    }
                    
                }
               
            }
        }
    }
}
