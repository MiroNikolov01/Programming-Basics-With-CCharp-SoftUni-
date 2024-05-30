using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            string products = string.Empty;
            double totalPrice = 0;
            int countPurchases = 0;
            double sum = 0.0;
            for (int i = 1; i <= clients; i++)
            {

                while ((products = Console.ReadLine()) != "Finish")
                {
                    switch (products)
                    {
                        case "basket": countPurchases++; totalPrice += 1.50; break;
                        case "wreath": countPurchases++; totalPrice += 3.80; break;
                        case "chocolate bunny": countPurchases++; totalPrice += 7; break;
                    }
                }
                if (products =="Finish")
                {
                    if (countPurchases % 2 == 0)
                    {
                        totalPrice *= 0.80;
                    }
                    Console.WriteLine($"You purchased {countPurchases} items for {totalPrice:F2} leva.");
                    sum += totalPrice;
                    totalPrice = 0;
                    countPurchases = 0;
                }
            }
            Console.WriteLine($"Average bill per client is: {sum / clients:F2} leva.");

        }
    }
}
