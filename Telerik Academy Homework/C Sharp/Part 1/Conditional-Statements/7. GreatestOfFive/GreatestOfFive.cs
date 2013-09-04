using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers to see which is the greatest.");
        Console.Write("Enter the first one: ");
        float firstNum = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the second one: ");
        float secondNum = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the third one: ");
        float thirdNum = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the fourth one: ");
        float fourthNum = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the fifth one: ");
        float fifthNum = Convert.ToSingle(Console.ReadLine());

        if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum)     // checking the firs one
        {
            Console.WriteLine("Your first number [{0}] is the greatest.", firstNum);
        }
        if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum)     // checking the second one
        {
            Console.WriteLine("Your second number [{0}] is the greatest.", secondNum);
        }
        if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum)     // checking the third one
        {
            Console.WriteLine("Your third number [{0}] is the greatest.", thirdNum);
        }
        if (fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum)     // checking the fourth one
        {
            Console.WriteLine("Your fourth number [{0}] is the greatest.", fourthNum);
        }
        if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > thirdNum && fifthNum > fourthNum)     // checking the fifth one
        {
            Console.WriteLine("Your fifth number [{0}] is the greatest.", fifthNum);
        }
    }
}
