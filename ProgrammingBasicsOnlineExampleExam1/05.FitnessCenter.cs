using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countClient = int.Parse(Console.ReadLine());
            double trainedTotal = 0.0;
            double boughtProducts = 0.0;
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 0; i < countClient; i++)
            {
                string typeClient = Console.ReadLine();
                switch (typeClient)
                {
                    case "Back": back++; trainedTotal++;break;
                    case "Chest": chest++; trainedTotal++; break;
                    case "Legs": legs++; trainedTotal++; break;
                    case "Abs": abs++; trainedTotal++; break;
                    case "Protein shake": proteinShake++; boughtProducts++; break;
                    case "Protein bar": proteinBar++; boughtProducts++; break; 
                }
            }
            double percentTrained = trainedTotal / countClient * 100;
            double percentProductsSold = boughtProducts / countClient * 100;
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentTrained:F2}% - work out");
            Console.WriteLine($"{percentProductsSold:F2}% - protein");
        }
    }
}
