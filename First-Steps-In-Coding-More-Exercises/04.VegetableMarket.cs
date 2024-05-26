using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgVegatables = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());
            int totalKgVegatables = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());

            double vegatableCost = kgVegatables * totalKgVegatables;
            double fruitCost = kgFruits * totalKgFruits;
            double totalCost = vegatableCost + fruitCost;


            double totalCostInEuro = totalCost / 1.94;
            string formattedReulst = totalCostInEuro.ToString("F2");
            Console.WriteLine(formattedReulst);





        }
    }
}       
            

