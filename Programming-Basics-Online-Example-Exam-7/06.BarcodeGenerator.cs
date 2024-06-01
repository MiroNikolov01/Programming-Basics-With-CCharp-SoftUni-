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
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int x1 = int.Parse(first[0].ToString());
            int x2 = int.Parse(first[1].ToString());
            int x3 = int.Parse(first[2].ToString());
            int x4 = int.Parse(first[3].ToString());
            int y1 = int.Parse(second[0].ToString());
            int y2 = int.Parse(second[1].ToString());
            int y3 = int.Parse(second[2].ToString());
            int y4 = int.Parse(second[3].ToString());

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
