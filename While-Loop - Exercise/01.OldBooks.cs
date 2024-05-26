using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string aniBook = Console.ReadLine();
            string books = string.Empty;
            int countBooks = 0;
            while ((books = Console.ReadLine()) != "No More Books")
            {
                if (books != aniBook)
                {
                    countBooks++;
                }
                else
                {
                    Console.WriteLine($"You checked {countBooks} books and found it."); return;

                }
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {countBooks} books.");
        }
    }
}
