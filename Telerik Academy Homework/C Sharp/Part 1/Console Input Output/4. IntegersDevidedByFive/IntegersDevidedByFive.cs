using System;

class IntegersDevidedByFive
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers to see how many numbers between them (inclusive) can be divided by 5 without reminder.\r\n");
        Console.WriteLine("Please, enter the first number: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the second number: ");
        int secondNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("The numbers you're looking for are:");
        
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0}, ", i);
            }
        }
        Console.Write("\b\b \r\n");
    }
}
