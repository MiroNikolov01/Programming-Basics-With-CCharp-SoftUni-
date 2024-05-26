using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               string text = Console.ReadLine();
                if (text == "Stop")
                {
                    break;
                }
            Console.WriteLine(text);
            }
        }
    }
}
