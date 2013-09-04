using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("This program will help you sorting three real numbers in descending order.");
        Console.WriteLine("Enter the first one: ");
        float firstNum = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the second one: ");
        float secondNum = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the third one: ");
        float thirdNum = Convert.ToSingle(Console.ReadLine());

        if (firstNum > secondNum && firstNum > thirdNum)    // firstNum is the greatest
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("Your numbers in descending order:\r\n{0}\r\n{1}\r\n{2}", firstNum, secondNum, thirdNum);
            }
            else
            {
                Console.WriteLine("Your numbers in descending order:\r\n{0}\r\n{1}\r\n{2}", firstNum, thirdNum, secondNum);
            }
        }
        if (secondNum > firstNum && secondNum > thirdNum)   //secondNum is the greatest
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("Your numbers in descending order:\r\n{0}\r\n{1}\r\n{2}", secondNum, firstNum, thirdNum);
            }
            else
            {
                Console.WriteLine("Your numbers in descending order:\r\n{0}\r\n{1}\r\n{2}", secondNum, thirdNum, firstNum);
            }
        }
        if (thirdNum > firstNum && thirdNum > secondNum)    //thirdNum is the greatest
        {
            if (firstNum > secondNum)
            {
                Console.WriteLine("Your numbers in descending order:\r\n{0}\r\n{1}\r\n{2}", thirdNum, firstNum, secondNum);
            }
            else
            {
                Console.WriteLine("Your numbers in descending order:\r\n{0}\r\n{1}\r\n{2}", thirdNum, secondNum, firstNum);
            }
        }
    }
}
