using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            
            double countHearthstone = 0;
            double countOverwatch = 0;
            double countFornite = 0;
            double countOthers = 0;


            for (int i = 1; i <= soldGames; i++)
            {
                string gameName = Console.ReadLine();
                switch (gameName)
                {
                    case "Hearthstone": countHearthstone++; break;
                    case "Fornite":  countFornite++; break;
                    case "Overwatch":  countOverwatch++;
                        break;
                    default: countOthers++;
                        break;
                }
            }
            Console.WriteLine($"Hearthstone - {countHearthstone / soldGames * 100:F2}%");
            Console.WriteLine($"Fornite - {countFornite / soldGames * 100:F2}%");
            Console.WriteLine($"Overwatch - {countOverwatch / soldGames * 100:F2}%");
            Console.WriteLine($"Others - {countOthers / soldGames * 100:F2}%");
        }
    }
}
