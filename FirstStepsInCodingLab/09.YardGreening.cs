using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetres = double.Parse(Console.ReadLine());
           
            double priceYard = squareMetres * 7.61;
            double discount = priceYard * 0.18;
            double totalPriceWithDiscount = priceYard - discount;
            Console.WriteLine("The final price is: "+totalPriceWithDiscount+" lv");
            Console.WriteLine("The discount is: "+discount+ " lv");



        }
    }
}
