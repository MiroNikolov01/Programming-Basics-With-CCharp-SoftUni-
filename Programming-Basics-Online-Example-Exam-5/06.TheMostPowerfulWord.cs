using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            double sum = 0.0;
            double maxSum = double.MinValue;
            char letter;
            string strongestWord = string.Empty;
            while ((word = Console.ReadLine()) != "End of words")
            {
                sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                     letter = word[i];
                        sum += letter;
                }
                letter = word[0];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
                {
                    sum *= word.Length;
                }
                else
                {
                    sum /= Math.Floor((double)word.Length);
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    strongestWord = word;
                }
            }
            Console.WriteLine($"The most powerful word is {strongestWord} - {maxSum}");
        }
    }
}
