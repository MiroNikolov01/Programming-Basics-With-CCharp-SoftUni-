using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalGrade = 0.0;
            int degree = 1;
            int countGrades = 0;
            while (true)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrade += grade;
                if (grade >= 4)
                {
                    degree++;
                    countGrades++;
                }
                else
                {
                    grade = double.Parse(Console.ReadLine());
                    if (grade < 4)
                    {
                        Console.WriteLine($"{name} has been excluded at {degree} grade");
                        return;
                    }
                }
                if (degree > 12)
                {
                    break;
                }
            }
            double averageGrade = totalGrade / countGrades;
            if (degree > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }

        }
    }
}
