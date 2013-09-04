using System;

class IntegerCheck
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number: ");
        string enteredNumber = Console.ReadLine();
        int converted = Int32.Parse(enteredNumber);
        int mask = 1;
        int convertedAndMask = converted & mask;
        if (convertedAndMask == 1)
        {
            Console.WriteLine("Entered number is an odd number.");
        }
        else if (convertedAndMask == 0)
        {
            Console.WriteLine("Entered number is an even number.");
        }
    }
}