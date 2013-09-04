// Write methods that calculate the surface of a triangle by given:
//  - Side and an altitude to it;
//  - Three sides;
//  - Two sides and an angle between them.
//  Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SurfaceOfATriangle
{
    class SurfaceOfATriangle
    {
        static void Main()
        {
            // Calculation by side and altitude
            Console.Write("To calculate the surfase of a triangle by SIDE and ALTITUDE to it, please enter the side length: ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("Now, enter altitude length: ");
            double altitude = double.Parse(Console.ReadLine());

            double surface = (side * altitude) / 2;
            Console.WriteLine("The surface is: {0}", surface);
            Console.WriteLine();

            // Calculation by three sides
            Console.Write("To calculate the surfase of a triangle by THREE SIDES, please enter side 'a' length: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Now, enter side 'b' length: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Now, enter side 'c' length: ");
            double sideC = double.Parse(Console.ReadLine());

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            surface = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            Console.WriteLine("The surface is: {0}", surface);
            Console.WriteLine();

            // Calculation by Two sides and an angle between them
            Console.Write("To calculate the surfase of a triangle by TWO SIDES and an ANGLE between them, please enter side 'a' length: ");
            sideA = double.Parse(Console.ReadLine());

            Console.Write("Now, enter side 'b' length: ");
            sideB = double.Parse(Console.ReadLine());

            Console.Write("Now, enter angle in radians: ");
            double angle = double.Parse(Console.ReadLine());

            surface = (sideA * sideB * Math.Sin(angle)) / 2;
            Console.WriteLine("The surface is: {0}", surface);
        }
    }
}
