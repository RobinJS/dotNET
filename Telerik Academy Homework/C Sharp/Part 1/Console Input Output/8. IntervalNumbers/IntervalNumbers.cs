using System;

class IntervalNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number to see all integer numbers between 1 and this number.");
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 2; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
