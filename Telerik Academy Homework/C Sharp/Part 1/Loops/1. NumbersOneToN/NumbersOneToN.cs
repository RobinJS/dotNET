using System;

class NumbersOneToN
{
    static void Main()
    {
        Console.WriteLine("To print all the numbers from 1 to N, please enter a value for N: ");
        int n;
        while (true)
        {
            bool value = Int32.TryParse(Console.ReadLine(), out n);
            if (value == false)
            {
                Console.WriteLine("Please, enter a number.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0}, ", i);
                }
                Console.Write("\b\b \r\n");
            }
        }
    }
}
