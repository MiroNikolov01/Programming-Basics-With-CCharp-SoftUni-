using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountEggs = int.Parse(Console.ReadLine());
            int eggsSold = 0;
            int eggs = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Close")
            {
                eggs = int.Parse(Console.ReadLine());
                if (command == "Fill")
                {
                    amountEggs += eggs;
                }
                if (amountEggs < eggs)
                {
                    break;
                }
                if (command == "Buy")
                {
                    amountEggs -= eggs;
                    eggsSold += eggs;
                }
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{eggsSold} eggs sold.");
            }
            else if (amountEggs < eggs)
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {amountEggs}.");
            }
        }
    }
}
