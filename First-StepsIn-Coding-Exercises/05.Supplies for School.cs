using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double cleaningChemical = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            procent = procent / 100;


            double pricePens = pens * 5.80;
            double priceMarkers = markers * 7.20;
            double priceCleaningChemical = cleaningChemical * 1.20;

            double totalMaterialsPrice = (pricePens + priceMarkers + priceCleaningChemical);
           
            Console.WriteLine(totalMaterialsPrice - (totalMaterialsPrice * procent));

            //Цена с намаление = 43.60 – (43.60 * 0.13) = 37.932 лв.
        }
    }
}
