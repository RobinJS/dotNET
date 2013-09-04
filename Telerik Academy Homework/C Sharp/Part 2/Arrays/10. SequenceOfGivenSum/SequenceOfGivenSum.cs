// Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;

class SequenceOfGivenSum
{
    static void Main()
    {

        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int targetSum = 11;
        int currentSum = 0;
        int beginning = 0;
        int end = 0;

        for (int index = 0; index < array.Length; index++)
        {
            if (currentSum == targetSum)
            {
                break;
            }

            for (int currnetIndex = index; currnetIndex < array.Length; currnetIndex++)
            {
                currentSum += array[currnetIndex];
                if (currentSum == targetSum)
                {
                    beginning = index;
                    end = currnetIndex;

                }
                else if (currentSum > targetSum)
                {
                    currentSum = 0;
                    break;
                }
            }
        }

        // printing rsult
        if (end == 0)
        {
            Console.WriteLine("There is no sequence of integers with sum = {0}.", targetSum);
        }
        else
        {
            Console.WriteLine("From index [{0}] to index [{1}] of the array.", beginning, end);
            Console.WriteLine("The numbers are:");
            for (int i = beginning; i <= end; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}