//Write a program that removes from given sequence all negative numbers.

using System;
using System.Collections.Generic;

namespace _5.NegativeNumbers
{
    class NegativeNumbers
    {
        static void Main()
        {
            List<int> sequence = new List<int> { 9, 5, -3, 6, -8, 5, -5, 21, 5, 6, -5, 8, -6 };
            int index = 0;

            while (index < sequence.Count)
            {
                if (sequence[index] < 0)
                {
                    sequence.RemoveAt(index);
                }

                index++;
            }

            Console.WriteLine("The sequence shanged:");
            foreach (int number in sequence)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
