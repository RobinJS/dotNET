using System;

namespace _3.ValueToPrint
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[100];
            int expectedValue = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    if (numbers[i] == expectedValue)
                    {
                        i = 666;
                        Console.WriteLine("Value Found");
                    }
                }

                Console.WriteLine(numbers[i]);
            }

            // More code here
        }
    }
}
