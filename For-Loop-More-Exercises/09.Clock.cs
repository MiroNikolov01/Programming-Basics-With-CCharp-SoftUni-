using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {

            Console.WriteLine($"{hour} : {minute}");
                }
            }
        }
    }
}
