using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            double totalGrades = 0;
            int countGrade = 0;
            double top = 0;
            double b4b5 = 0;
            double b3b4 = 0;
            double fail = 0;
            for (int i = 1; i <= countStudents; i++)
            {
            double grade = double.Parse(Console.ReadLine());
                totalGrades += grade;
                countGrade++;
                if (grade >= 5) top++;
                else if (grade >= 4 && grade <= 4.99) b4b5++;
                else if (grade >= 3 && grade <= 3.99) b3b4++;
                else if (grade < 3) fail++;
            }
            Console.WriteLine($"Top students: {(double)top / countGrade * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)b4b5 / countGrade * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)b3b4 / countGrade * 100:F2}%");
            Console.WriteLine($"Fail: {(double)fail / countGrade * 100:F2}%");
            Console.WriteLine($"Average: {totalGrades / countStudents:F2}");
        }
    }
}
