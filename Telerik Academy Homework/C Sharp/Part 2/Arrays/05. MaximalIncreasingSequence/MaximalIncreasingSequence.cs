// Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        // entering data
        Console.WriteLine("Enter length for integer array: ");
        int arrLength = int.Parse(Console.ReadLine());

        int[] intArray = new int[arrLength];

        for (int index = 0; index < arrLength; index++)
        {
            Console.Write("Enter element {0} of the array: ", index);
            intArray[index] = int.Parse(Console.ReadLine());
        }

        int first = intArray[0];
        int next = 0;
        int length = 1;
        int bestLength = 0;
        int end = 0;

        // searching for the maximal increasing sequence
        for (int i = 1; i < intArray.Length; i++)
        {
            next = intArray[i];
            if (first < intArray[i])
            {
                length++;
                if (length > bestLength)
                {
                    bestLength = length;
                    end = i;
                }
            }
            else
            {
                length = 1;
            }

            first = intArray[i];
        }

        int beginning = end - (bestLength - 1);
        Console.WriteLine();

        // printing info
        Console.WriteLine("The maximal sequence is {0}", bestLength);
        Console.WriteLine("From index [{0}] to index [{1}] of the array", beginning, end);
        Console.Write("Which are the numbers: ");
        for (int i = beginning; i <= end; i++)
        {
            Console.Write("{0} ", intArray[i]);
        }
        Console.WriteLine();
    }
}
