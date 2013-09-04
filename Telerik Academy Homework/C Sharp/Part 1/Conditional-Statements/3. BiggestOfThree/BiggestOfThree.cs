using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Find the biggest of three integers!");
        Console.WriteLine("Enter the first one: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second one: ");
        int secondNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third one: ");
        int thirdNum = Int32.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("Your first number [{0}] is the biggest.", firstNum);
            }
        }
        if (secondNum > firstNum)
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("Your second number [{0}] is the biggest.", secondNum);
            }
        }
        if (thirdNum > firstNum)
        {
            if (thirdNum > secondNum)
            {
                Console.WriteLine("Your third number [{0}] is the biggest.", thirdNum);
            }
        }
        else if ((firstNum == secondNum))
        {
            if (secondNum == thirdNum)
            {
                Console.WriteLine("The three numbers are equal.");
            }
        }
    }
}
