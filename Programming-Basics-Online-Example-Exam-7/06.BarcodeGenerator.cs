using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int x1 = first / 10 / 10 / 10 % 10;
            int x2 = first / 10 / 10 % 10;
            int x3 = first / 10 % 10;
            int x4 = first % 10;
            int y1 = second / 10 / 10 / 10 % 10;
            int y2 = second / 10 / 10 % 10;
            int y3 = second / 10 % 10;
            int y4 = second % 10;

            for (int i1 = x1; i1 <= y1; i1++)
            {
                for (int i2 = x2; i2 <= y2; i2++)
                {
                    for (int i3 = x3; i3 <= y3; i3++)
                    {
                        for (int i4 = x4; i4 <= y4; i4++)
                        {
                            if (i1 % 2 !=0 && i2 % 2 !=0 && i3 % 2 != 0 && i4 % 2 != 0)
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
