using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceVoucher = int.Parse(Console.ReadLine());
            string purchases = string.Empty;
            int boughtTickets = 0;
            int boughtProducts = 0;
            int priceTicket = 0;
            while ((purchases = Console.ReadLine()) != "End")
            {
                int symbol = purchases.Length;
                int letter1 = purchases[0];
                int letter2 = purchases[1];
                priceTicket = 0;
                if (symbol > 8)
                {
                    priceTicket = letter1 + letter2;
                    if (priceVoucher >= priceTicket)
                    {
                        priceVoucher -= priceTicket;
                        boughtTickets++;
                    }
                    else
                    {
                        Console.WriteLine($"{boughtTickets}\n{boughtProducts}");
                        return;
                    }
                }
                else if (symbol <= 8)
                {
                    priceTicket = letter1;
                    if (priceVoucher >= priceTicket)
                    {
                        priceVoucher -= priceTicket;
                        boughtProducts++;
                    }
                    else
                    {
                        Console.WriteLine($"{boughtTickets}\n{boughtProducts}");
                        return;
                    }
                }

            }
            if (purchases == "End")
            {
                Console.WriteLine($"{boughtTickets}\n{boughtProducts}");
            }
        }
    }
}
