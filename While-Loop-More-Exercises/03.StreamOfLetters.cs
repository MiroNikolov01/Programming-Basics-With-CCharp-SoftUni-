using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            string word = "";
            string sumSicretCommand = "";
            char currentLetter = '+';
            string newWord = "";

            while (command != "End")
            {
                command = Console.ReadLine();
                if (command != "End")
                {
                    currentLetter = char.Parse(command); //Converting from string to char
                    if ((currentLetter >= 65 && currentLetter <= 90) || (currentLetter >= 97 && currentLetter <= 122)) //Latin Alphabet Check from the ASCII TABLE
                    {
                        if (currentLetter == 'c' && !(sumSicretCommand.Contains("c"))) 
                        {
                            sumSicretCommand += char.ToString(currentLetter); //Adding the special symbol (c)

                        }
                        else if (currentLetter == 'o' && !(sumSicretCommand.Contains("o")))
                        {
                            sumSicretCommand += char.ToString(currentLetter); //Adding the special symbol (o)
                        }
                        else if (currentLetter == 'n' && !(sumSicretCommand.Contains("n")))
                        {
                            sumSicretCommand += char.ToString(currentLetter); //Adding the special symbol (n)
                        }
                        else
                        {
                            word += char.ToString(currentLetter); // Adding symbols to the word

                        }
                        if (sumSicretCommand.Contains("c") && sumSicretCommand.Contains("o") && sumSicretCommand.Contains("n")) // Checking if every symbol is collected.
                        {
                            word += " ";
                            newWord = word;
                            sumSicretCommand = "";
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (command == "End")
            {
                Console.WriteLine(newWord);
            }
        }
    }
}

