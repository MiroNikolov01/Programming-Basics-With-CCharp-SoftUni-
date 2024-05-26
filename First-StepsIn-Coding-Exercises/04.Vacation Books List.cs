using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {

            int countPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = countPages / pages;
            int result = hours / days;
            Console.WriteLine(result);



        }
    }
}
