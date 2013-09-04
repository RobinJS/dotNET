using System;

class CircleEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a positive number for the radius of a circle ");
        Console.WriteLine("to see it's perimeter and area: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        float perimeter = 2 * (float)Math.PI * radius;
        float area = (float)Math.PI * radius * radius;
        Console.WriteLine("Circle's perimeter is: {0:F2}", perimeter);
        Console.WriteLine("Circle's area is: {0:F2}", area);
    }
}
