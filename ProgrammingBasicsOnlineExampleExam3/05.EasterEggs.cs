using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEggs = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            for (int i = 1; i <= totalEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red": red++; break;
                    case "orange": orange++; break;
                    case "blue": blue++; break;
                    case "green": green++; break;
                }
            }
            int[] number = { red, orange, blue, green };
            int maxValue = number.Max(); // Searching the maximum number
            string maxColor = string.Empty;
            if (maxValue == green)
                maxColor = "green";
            else if (maxValue == red)
                maxColor = "red";
            else if (maxValue == blue)
                maxColor = "blue";
            else 
                maxColor = "orange";

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxValue} -> {maxColor}");

        }
    }
}
