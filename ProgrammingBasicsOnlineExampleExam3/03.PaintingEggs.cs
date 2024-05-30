using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeEgg = Console.ReadLine();
            string colorEgg = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (sizeEgg == "Large")
            {
                switch (colorEgg)
                {
                    case "Red":
                        price = count * 16;
                        break;
                    case "Green":
                        price = count * 12;
                        break;
                    case "Yellow":
                        price = count * 9;
                        break;
                }
            }
            else if (sizeEgg == "Medium")
            {

                switch (colorEgg)
                {
                    case "Red":
                        price = count * 13;
                        break;
                    case "Green":
                        price = count * 9;
                        break;
                    case "Yellow":
                        price = count * 7;
                        break;
                }
            }
            else
            {
                switch (colorEgg)
                {
                    case "Red":
                        price = count * 9;
                        break;
                    case "Green":
                        price = count * 8;
                        break;
                    case "Yellow":
                        price = count * 5;
                        break;
                }
            }
            double expenses = price * 0.35;
            double totalPrice = price - expenses;
            Console.WriteLine($"{totalPrice:F2} leva.");
        }
    }
}
