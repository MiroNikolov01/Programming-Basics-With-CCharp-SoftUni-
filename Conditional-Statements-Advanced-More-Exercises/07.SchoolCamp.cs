using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int countStudents = int.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double schoolTotal = 0.0;
            string typeOfSport = string.Empty;
            if (season == "Winter")
            {
                switch (groupType)
                {
                    case "girls":
                        typeOfSport = "Gymnastics";
                        schoolTotal = countStudents * 9.60 * countNights;
                        break;
                    case "boys":
                        typeOfSport = "Judo";
                        schoolTotal = countStudents * 9.60 * countNights;
                        break;
                    case "mixed":
                        typeOfSport = "Ski";
                        schoolTotal = countStudents * 10 * countNights;
                        break;
                }
            }
            else if (season == "Spring")
            {
                switch (groupType)
                {
                    case "girls":
                        typeOfSport = "Athletics";
                        schoolTotal = countStudents * 7.20 * countNights;
                        break;
                    case "boys":
                        typeOfSport = "Tennis";
                        schoolTotal = countStudents * 7.20 * countNights;
                        break;
                    case "mixed":
                        typeOfSport = "Cycling";
                        schoolTotal = countStudents * 9.50 * countNights;
                        break;
                }
            }
            else if (season == "Summer")
            {
                switch (groupType)
                {
                    case "girls":
                        typeOfSport = "Volleyball";
                        schoolTotal = countStudents * 15 * countNights;
                        break;
                    case "boys":
                        typeOfSport = "Football";
                        schoolTotal = countStudents * 15 * countNights;
                        break;
                    case "mixed":
                        typeOfSport = "Swimming";
                        schoolTotal = countStudents * 20 * countNights;
                        break;
                }
            }
            if (countStudents >= 50)
            {
                schoolTotal *= 0.50;
            }
            else if (countStudents >= 20 && countStudents < 50)
            {
                schoolTotal *= 0.85;
            }
            else if (countStudents >= 10 && countStudents < 20)
            {
                schoolTotal *= 0.95;
            }
            Console.WriteLine($"{typeOfSport} {schoolTotal:F2} lv.");
        }
    }
}
