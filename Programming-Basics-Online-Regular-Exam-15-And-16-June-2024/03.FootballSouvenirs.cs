using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int countBoughtSouvenirs = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            switch (team)
            {
                case "Argentina":
                    switch (souvenir)
                    {
                        case "flags": totalPrice = countBoughtSouvenirs * 3.25; break;
                        case "caps": totalPrice = countBoughtSouvenirs * 7.20; break;
                        case "posters": totalPrice = countBoughtSouvenirs * 5.10; break;
                        case "stickers": totalPrice = countBoughtSouvenirs * 1.25; break;
                        default: Console.WriteLine("Invalid stock!"); return;
                    }
                    break;
                case "Brazil":
                    switch (souvenir)
                    {
                        case "flags": totalPrice = countBoughtSouvenirs * 4.20; break;
                        case "caps": totalPrice = countBoughtSouvenirs * 8.50; break;
                        case "posters": totalPrice = countBoughtSouvenirs * 5.35; break;
                        case "stickers": totalPrice = countBoughtSouvenirs * 1.20; break;
                        default: Console.WriteLine("Invalid stock!"); return;
                    }
                    break;
                case "Croatia":
                    switch (souvenir)
                    {
                        case "flags": totalPrice = countBoughtSouvenirs * 2.75; break;
                        case "caps": totalPrice = countBoughtSouvenirs * 6.90; break;
                        case "posters": totalPrice = countBoughtSouvenirs * 4.95; break;
                        case "stickers": totalPrice = countBoughtSouvenirs * 1.10; break;
                        default: Console.WriteLine("Invalid stock!"); return;
                    }
                    break;
                case "Denmark":
                    switch (souvenir)
                    {
                        case "flags": totalPrice = countBoughtSouvenirs * 3.10; break;
                        case "caps": totalPrice = countBoughtSouvenirs * 6.50; break;
                        case "posters": totalPrice = countBoughtSouvenirs * 4.80; break;
                        case "stickers": totalPrice = countBoughtSouvenirs * 0.90; break;
                        default: Console.WriteLine("Invalid stock!"); return;
                    }
                    break;
                default: Console.WriteLine("Invalid country!"); return; 
            }
            Console.WriteLine($"Pepi bought {countBoughtSouvenirs} {souvenir} of {team} for {totalPrice:F2} lv.");


        }
    }
}
