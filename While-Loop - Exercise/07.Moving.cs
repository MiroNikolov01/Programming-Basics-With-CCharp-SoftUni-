using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int cubicMeters = 0;
            int space = width * lenght * height;
            while ((command = Console.ReadLine()) != "Done")
            {
                int boxes = int.Parse(command);
                cubicMeters += boxes;
                if (space < cubicMeters)
                {
                    break;
                }
            }
            if (space < cubicMeters)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(cubicMeters - space)} Cubic meters more.");
            }
            else if (command == "Done")
            {
                Console.WriteLine($"{Math.Abs(cubicMeters - space)} Cubic meters left.");
            }
        }
    }
}
