using System;
using System.Numerics;

class Zeros
{
    static void Main()
    {
        Console.WriteLine("This program calculates how many trailing zeros present at the end of the number N!.\r\nTo see that, enter a positive integer number for N:");
        int userN;
        do
        {
            bool checkN = Int32.TryParse(Console.ReadLine(), out userN);
            if (userN < 0)
            {
                Console.WriteLine("You must enter an integer number > 0");
            }
        }
        while (userN < 0);

        int sum = 0;
        for (int denominator = 5; denominator < userN; denominator *= 5)
        {
            sum += userN / denominator;
        }

        Console.WriteLine("Sum of zeros = " + sum);
        Console.WriteLine("If you want to see {0}! press \"y\". To exit, press Enter key twice.", userN);
        
        ConsoleKeyInfo end = Console.ReadKey();
        
        if (end.KeyChar == 'y')
        
        {
            int tempN = userN;
            BigInteger factorialN = 1;
            while (tempN > 0)
            {
                factorialN *= tempN;
                tempN--;
            }
            Console.WriteLine("\r\n{0}! = {1}", userN, factorialN);
        }
    }
}
