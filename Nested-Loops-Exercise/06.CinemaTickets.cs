using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int student = 0;
            int standard = 0;
            int kid = 0;

            while (input != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int seatstaken = 0;
                for (int i = 0; i < seats; i++)
                {
                    bool isEnd = false;
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "student":
                            student++; seatstaken++;
                            break;
                        case "standard":
                            standard++; seatstaken++;
                            break;
                        case "kid":
                            kid++; seatstaken++;
                            break;
                        case "End": isEnd = true; break;
                    }
                    if (isEnd) break;
                }
                Console.WriteLine($"{input} - {seatstaken * 100.0 / seats:f2}% full.");
                input = Console.ReadLine();
            }
            int allTickets = student + standard + kid;
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(double)student / allTickets * 100:F2}% student tickets.");
            Console.WriteLine($"{(double)standard / allTickets * 100:F2}% standard tickets.");
            Console.WriteLine($"{(double)kid / allTickets * 100:F2}% kids tickets.");
        }

    }
}


