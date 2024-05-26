using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJudge = int.Parse(Console.ReadLine());
            string namePresentation = Console.ReadLine();

            double totalGrades = 0;
            double averageGrades = 0;
            int countGrades = 0;
            double averegeSum = 0;

            while (namePresentation != "Finish")
            {
                for (int i = 0; i < countJudge; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    averegeSum += grade;
                    totalGrades += grade;
                    countGrades++;
                }
                averageGrades = averegeSum;
                averegeSum = 0;
                Console.WriteLine($"{namePresentation} - {averageGrades / countJudge:F2}.");
                namePresentation = Console.ReadLine();
            }
            if (namePresentation == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {totalGrades / countGrades:F2}.");
            }


        }
    }
}
