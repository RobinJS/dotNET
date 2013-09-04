using System;

class FibonacciSum
{
    static void Main()
    {
        Console.WriteLine("To calculate the sum of the first N members of the sequence of Fibonacci (starting with 0, 1...), please enter a positive integer number for N:");
        uint n;
        do
        {
            bool checkN = UInt32.TryParse(Console.ReadLine(), out n);
            if (n <= 0)
            {
                Console.WriteLine("You must enter an integer number > 0");
            }
        }
        while (n <= 0);

        uint firstMember = 0;
        uint secondMember = 1;
        uint sum = 1;
        for (int i = 2; i < n; i++)
        {
            uint result = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = result;
            sum = result + sum;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
