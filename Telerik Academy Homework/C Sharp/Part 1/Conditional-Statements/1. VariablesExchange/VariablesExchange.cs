using System;

class VariablesExchange
{
    static void Main()
    {
        Console.WriteLine("This program will exchange the positions of two integer variables if the first one is greater than the second one.");
        Console.WriteLine("Enter the first number: ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNumber = Int32.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("Your first number is now: {0}", firstNumber);
            Console.WriteLine("Your second number is now: {0}", secondNumber);
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine("Your second number is greater.");
        }
    }
}