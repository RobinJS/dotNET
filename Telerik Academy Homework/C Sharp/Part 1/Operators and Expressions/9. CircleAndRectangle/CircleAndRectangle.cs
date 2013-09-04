using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number for X: ");
        float x = Single.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter a number for Y: ");
        float y = Single.Parse(Console.ReadLine());

        //counting circle
        float circle = (float)Math.Pow((x - 1), 2) + (float)Math.Pow((y - 1), 2);
        bool withinCircle = circle >= -9 && circle <= 9;

        //counting rectangle
        bool rect = x >= -1 && x <= 5 && y >= -1 && y <= 1;

        //checking the point
        if (withinCircle && rect)
        {
            Console.WriteLine("The selected point is within both the circle and the rectangle.");
        }
        else if (withinCircle && !rect)
        {
            Console.WriteLine("The selected point is within the circle, but out of the rectangle.");
        }
        else if (!withinCircle && rect)
        {
            Console.WriteLine("The selected point is out of the circle, but within the rectangle.");
        }
        else if (!withinCircle && !rect)
        {
            Console.WriteLine("The selected point is outside of both the circle and the rectangle.");
        }
    }
}
