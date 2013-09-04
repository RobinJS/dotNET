using System;

class GreaterInteger
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers to see which one is greater.\r\n");
        Console.WriteLine("Please, enter the first number: ");
        float firstNum = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Now enter the second number: ");
        float secondNum = Convert.ToSingle(Console.ReadLine());
        float greaterNum = Math.Max(firstNum, secondNum);
        Console.WriteLine("The greater number is: " + greaterNum);
    }
}
