using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("This program prints out the first 100 members of the sequence of Fibonacci.\r\n  To continue, press \"Enter\"...");
        Console.ReadLine();
        decimal firstMember = 0m;
        decimal secondMember = 1m;
        for (decimal i = 1; i <= 100; i++)
        {
            decimal result = firstMember + secondMember;
            Console.WriteLine("#{0} - {1}", i, result);
            firstMember = secondMember;
            secondMember = result;
        }
    }
}
