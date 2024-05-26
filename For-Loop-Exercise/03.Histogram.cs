using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200) countP1++;
                else if (num >= 200 && num <= 399) countP2++;
                else if (num >= 400 && num <= 599) countP3++;
                else if (num >= 600 && num <= 799) countP4++;
                else if (num >= 800) countP5++;
            }
            double percentP1 = (double)countP1 / n * 100;
            double percentP2 = (double)countP2 / n * 100;
            double percentP3 = (double)countP3 / n * 100;
            double percentP4 = (double)countP4 / n * 100;
            double percentP5 = (double)countP5 / n * 100;

            Console.WriteLine($"{percentP1:F2}%");
            Console.WriteLine($"{percentP2:F2}%");
            Console.WriteLine($"{percentP3:F2}%");
            Console.WriteLine($"{percentP4:F2}%");
            Console.WriteLine($"{percentP5:F2}%");

        }
    }
}
