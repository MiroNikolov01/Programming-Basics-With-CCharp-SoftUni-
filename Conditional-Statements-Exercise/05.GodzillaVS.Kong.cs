using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GodzillaVS.Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double budgetFilm = double.Parse(Console.ReadLine());
            int countOfStatist = int.Parse(Console.ReadLine());
            double clothingOneStatist = double.Parse(Console.ReadLine());

            double priceClothing = countOfStatist * clothingOneStatist;
            double priceDecors = budgetFilm * 0.10;

            if (countOfStatist > 150)
            {
                priceClothing = priceClothing - priceClothing * 0.10;
            }
            
            double totalSum = priceDecors + priceClothing;
            double moneyNeeded = totalSum - budgetFilm;
            double moneyLeft = budgetFilm - totalSum;
            
            if (totalSum < budgetFilm)
            {
                Console.WriteLine($"Action!\nWingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
              
                Console.WriteLine($"Not enough money!\nWingard needs {moneyNeeded:f2} leva more.");
            }

        }
        }
    }



