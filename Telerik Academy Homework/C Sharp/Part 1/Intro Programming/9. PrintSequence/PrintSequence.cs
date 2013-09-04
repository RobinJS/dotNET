using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            if (IsOdd(i))
            {
                Console.WriteLine(-i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }
}