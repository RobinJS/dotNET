using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number for side \"a\": ");
        int sideA = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter an integer number for side \"b\": ");
        int sideB = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter an integer number for height: ");
        int height = Int32.Parse(Console.ReadLine());
        int result = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The trapezoid's area is: " + result);
    }
}
