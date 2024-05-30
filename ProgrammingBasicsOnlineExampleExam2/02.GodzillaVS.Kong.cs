using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GodzillaVS.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int countOfStatist = int.Parse(Console.ReadLine());
            double priceClothesOneStatist = double.Parse(Console.ReadLine());
            //Calculations
            double priceDecors = filmBudget * 0.10; //10% from decors
            double priceClothes = countOfStatist * priceClothesOneStatist;

            if (countOfStatist > 150)
            {
                double percent = priceClothes - (priceClothes * 0.90);
                priceClothes = priceClothes - percent;
                
            }
            double totalSum = priceDecors + priceClothes;

            if (totalSum <= filmBudget)
            {
                double moneyLeft = Math.Abs(filmBudget - totalSum);
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = Math.Abs(totalSum - filmBudget);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }

        }
    }
}
