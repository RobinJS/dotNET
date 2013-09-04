using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number for X: ");
        float x = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter a number for Y: ");
        float y = Single.Parse(Console.ReadLine());
        float equation = (float)Math.Pow(x, 2) + (float)Math.Pow(y, 2);
        bool within = equation > -25 && equation < 25;
        if (within)
        {
            Console.WriteLine("The point with coordinates " + x + " and " + y + " is within a circle with radius 5 and center 0.");
        }
        else
        {
            Console.WriteLine("The point with coordinates " + x + " and " + y + " is outside a circle with radius 5 and center 0.");
        }
    }
}