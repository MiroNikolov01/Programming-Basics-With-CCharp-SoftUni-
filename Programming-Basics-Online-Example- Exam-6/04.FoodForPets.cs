using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
          
           int countDays = int.Parse(Console.ReadLine());
            double amountFood = double.Parse(Console.ReadLine());
            var dog = 0.0;
            var cat = 0.0;
            var totalBiscuit = 0.0;
            var totalEatenFood = 0.0;
            double percentEatenFood = 0.0;
            double percentEatenDog = 0.0;
            double percentEatenCat = 0.0;
            
            for (int i = 1; i <= countDays; i++)
            {
                int dogEatenFood = int.Parse(Console.ReadLine());
                int catEatenFood = int.Parse(Console.ReadLine());
                dog += dogEatenFood;
                cat += catEatenFood;
                totalEatenFood += dogEatenFood + catEatenFood;
                
                if (i % 3 == 0)
                {
                    totalBiscuit += (dogEatenFood + catEatenFood) * 0.10;
                }
                
                percentEatenFood = (totalEatenFood / amountFood) * 100;
                percentEatenDog = (dog / totalEatenFood) * 100;
                percentEatenCat = (cat / totalEatenFood) * 100;
            }
            
            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuit)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenCat:f2}% eaten from the cat.");
        }
    }
}
