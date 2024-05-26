using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for (int y = 0; y < currentNum.Length; y++)
                {
                    int indexNum = int.Parse(currentNum[y].ToString());
                    if (y % 2 == 0)
                    {
                        evenSum += indexNum;
                    }
                    else
                    {
                        oddSum += indexNum;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}


