using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgSkymriq =double.Parse(Console.ReadLine());
            double kgCaca = double.Parse(Console.ReadLine());
            double kgPalamyd = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMussels = int.Parse(Console.ReadLine());

            

            double pricePalamydForKg = kgSkymriq + kgSkymriq * 0.60 ;
            double costPalamyd = kgPalamyd * pricePalamydForKg;
            double priceSafridForKg = kgCaca + kgCaca *80/100;
            double costSafrid = kgSafrid * priceSafridForKg;
            double priceMussels = kgMussels * 7.50;
            double totalPrice = costPalamyd + costSafrid + priceMussels;
            string formattedResult = totalPrice.ToString("F2");
            Console.WriteLine(formattedResult);


        }
    }
}
