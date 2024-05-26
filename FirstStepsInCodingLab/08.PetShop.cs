using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double priceDogFood = dogFood * 2.5;
            double priceCatFood = catFood * 4;
            double result = priceDogFood + priceCatFood;
            Console.WriteLine(result+ " lv.");
        }
    }
}
