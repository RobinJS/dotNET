using System;

class PrintNotDivisibleOneToN
{
    static void Main()
    {
        Console.WriteLine("Print all the numbers from 1 to N that are not divisible by 3 and 7 at the same time. Please enter a value for N: ");
        int n;
        while (true)
        {
            bool value = Int32.TryParse(Console.ReadLine(), out n);
            if (value == false || n < 0)
            {
                Console.WriteLine("Please, enter a positive integer number.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 || i % 7 != 0)
                    {
                        Console.Write("{0}, ", i);
                    }
                }
                Console.Write("\b\b \r\n");
                break;
            }
        }
    }
}
