using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and password:");
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("correct password!");
            }
            else if (password != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
            if (name == "Miro")
            {
                Console.WriteLine("Correct name!");
            }
            else if (name != "Miro")
            {
                Console.WriteLine("Wrong name!");
            }
            
        }
    }
} 
