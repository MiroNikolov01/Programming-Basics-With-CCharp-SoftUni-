using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int topGrade = 0;
            int b4and5 = 0;
            int b3and4 = 0;
            int fail = 0;

            double totalGrades = 0;
            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrades += grade;
                if (grade < 3) fail++;
                else if (grade >= 3 && grade <= 3.99) b3and4++;
                else if (grade >= 4 && grade <= 4.99) b4and5++;
                else if (grade >= 5) topGrade++;
            }
           double avarage = totalGrades / students;
            double percentTop = (double)topGrade / students * 100;
            double percentB4And5 = (double)b4and5 / students * 100;
            double percentB3And4 = (double)b3and4 / students * 100;
            double percentFail = (double)fail / students * 100;

            
            Console.WriteLine($"Top students: {percentTop:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentB4And5:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentB3And4:F2}%");
            Console.WriteLine($"Fail: {percentFail:F2}%");
            Console.WriteLine($"Average: {avarage:F2}");

        }
    }
}
