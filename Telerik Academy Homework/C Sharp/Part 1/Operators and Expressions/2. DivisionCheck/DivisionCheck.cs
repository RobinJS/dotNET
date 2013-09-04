using System;

class DivisionCheck
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number: ");
        int entered = Int32.Parse(Console.ReadLine());
        bool devidedByFive = entered % 5 == 0;
        bool devidedBySeven = entered % 7 == 0;
        Console.WriteLine(devidedByFive && devidedBySeven ? entered + " CAN be devided by 5 and 7 in the same time." : entered + " CANNOT be devided by 5 and 7 in the same time.");
    }
}