using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //Walls Calculations
            double sideWalls = x * y;
            double windows = 1.5 * 1.5;
            double totalTwoSides = 2 * sideWalls - 2 * windows;
            double backWall = x * x; double frontDoor = 1.2 * 2;
            double wallFrontAndBack = 2 *backWall - frontDoor;
            double totalArea = totalTwoSides + wallFrontAndBack;
            double greenPaint = totalArea / 3.4;

            //Roof Calculations
            double roofTwoSides = 2 * (x * y);
            double roofTwoFrontSides = 2 * (x * h / 2); 
            double totalAreaRoof = roofTwoSides + roofTwoFrontSides;
            double redPaint = totalAreaRoof / 4.3;

            double resultTotalPaint = greenPaint;
             double resultTotalPaint2 = redPaint;
            string formattedResult = resultTotalPaint.ToString("F2");
            string formattedResult2 = resultTotalPaint2.ToString("F2");
            Console.WriteLine(formattedResult);
            Console.WriteLine(formattedResult2);





        }
    }
}
