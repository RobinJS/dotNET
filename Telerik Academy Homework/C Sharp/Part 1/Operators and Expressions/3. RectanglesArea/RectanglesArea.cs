using System;

class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number for width: ");
        string enteredWidth = Console.ReadLine();
        float width = Convert.ToSingle(enteredWidth);
        Console.WriteLine("Please, enter a number for height: ");
        string enteredHeight = Console.ReadLine();
        float height = Convert.ToSingle(enteredHeight);
        float result = width * height;
        Console.WriteLine("The rectangle's area is: " + result);
    }
}