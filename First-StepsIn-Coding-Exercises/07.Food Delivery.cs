using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double VeganMenu = double.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double veganPrice = VeganMenu * 8.15;

            double totalMenuPrice = chickenPrice + fishPrice + veganPrice;
            double desertPercent = totalMenuPrice * 20 / 100;
            double delivery = 2.50;

            Console.WriteLine(totalMenuPrice + desertPercent + delivery);
        }
    }
}
