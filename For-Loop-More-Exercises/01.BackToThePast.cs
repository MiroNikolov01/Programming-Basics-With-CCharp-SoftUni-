using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Back_To_ThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivanMoney = double.Parse(Console.ReadLine());
            int livingYear = int.Parse(Console.ReadLine());
            int age = 17;
            for (int i = 1800; i <= livingYear; i++)
            {
                age++;
                if (i % 2 == 0)
                {
                    ivanMoney -= 12000;
                }
                else
                {
                    ivanMoney -= 12000 + (age * 50);
                }
            }
            if (ivanMoney < 0)
            {
                
                Console.WriteLine($"He will need {Math.Abs(ivanMoney):f2} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {ivanMoney:f2} dollars left.");
            }
        }
    }
}

    

