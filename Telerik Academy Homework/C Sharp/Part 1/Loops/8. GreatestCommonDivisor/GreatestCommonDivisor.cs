using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("To calculate the greatest common devisor between two numbers (A and B), please enter their values.");
        Console.WriteLine("Enter number A:");
        int a;
        do
        {
            bool checkA = Int32.TryParse(Console.ReadLine(), out a);
            if (a <= 0)
            {
                Console.WriteLine("You must enter an integer number > 0");
            }
        }
        while (a <= 0);

        Console.WriteLine("Enter number B:");
        int b;
        do
        {
            bool checkB = Int32.TryParse(Console.ReadLine(), out b);
            if (b <= 0)
            {
                Console.WriteLine("You must enter an integer number > 0");
            }
        }
        while (b <= 0);

        int biggerNum = 0;
        int smallerNum = 0;
        if (a > b)
        {
            biggerNum = a;
            smallerNum = b;
        }
        else if (b > a)
        {
            biggerNum = b;
            smallerNum = a;
        }

        int remainder = biggerNum % smallerNum;

        if (remainder == 0)
        {
            remainder = smallerNum;
        }
        else
        {
            for (int i = 1; remainder == 0; i++)
            {
                biggerNum = smallerNum;
                smallerNum = remainder;

                remainder = biggerNum % smallerNum;
            }

        }
        Console.WriteLine("The answer is: " + remainder);
    }
}
