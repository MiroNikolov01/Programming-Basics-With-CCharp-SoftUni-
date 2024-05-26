using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double naylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double distiller = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());


            double priceNaylon = (naylon + 2) * 1.5;
            double pricePaint = (paint + paint * 0.10) * 14.50;
            double priceDistiller = distiller * 5.00;
            double bag = 0.40;

            double totalPriceMaterials = priceNaylon + pricePaint + priceDistiller + bag;
            double priceWorkers = (totalPriceMaterials * 0.30) * hours;
            double total = (totalPriceMaterials + priceWorkers);
            Console.WriteLine($"{total}");


        }
    }
}
