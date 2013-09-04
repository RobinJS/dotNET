using System;

class GrowUpCalculator
{
    static void Main()
    {
        Console.WriteLine("(Grow-up Calculator version 1) Please, enter your current age...");
        int getPresentAge = int.Parse(Console.ReadLine());
        int result = getPresentAge + 10;
        Console.WriteLine("After 10 years you will be " + result + " years old." + "\n");

        Console.WriteLine("(Grow-up Calculator version 2) Please, enter the year when you were born...");
        int getYear = int.Parse(Console.ReadLine());
        int getDateNow = DateTime.Now.Year;
        int result2 = (getDateNow - getYear) + 10;
        Console.WriteLine("After 10 years you will be " + result2 + " years old.");
    }
}
