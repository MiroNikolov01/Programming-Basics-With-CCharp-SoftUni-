using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsuccessfulGrades = int.Parse(Console.ReadLine());
            string task = string.Empty;
            int countUnsuccesfulGrades = 0;
            int sumGrades = 0;
            int countGrades = 0;
            int countTasks = 0;
            string lastTask = string.Empty;
            while ((task = Console.ReadLine()) != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                countGrades++;
                countTasks++;
                lastTask = task;
                if (grade <= 4)
                {
                    countUnsuccesfulGrades++;
                }
                if (unsuccessfulGrades == countUnsuccesfulGrades)
                {
                    Console.WriteLine($"You need a break, {countUnsuccesfulGrades} poor grades.");
                    return;
                }
            }
            double averageGrade = (double)sumGrades / countGrades;
            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {countTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
