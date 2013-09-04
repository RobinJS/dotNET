// Write a program that finds the sequence of maximal sum in given array. Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}

using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int CurrentSum;
        int maxSum = int.MinValue;
        int startIndex = 0;
        int endIndex = arr[0];

        // searching for the maximal sum
        for (int j = 0; j < arr.Length - 1; j++)
        {
            CurrentSum = 0;
            for (int i = j; i < arr.Length; i++)
            {
                CurrentSum += arr[i];

                if (CurrentSum > maxSum)
                {
                    maxSum = CurrentSum;
                    startIndex = j;
                    endIndex = i;
                }
            }
        }

        // printing results
        Console.WriteLine("Maximal sum: {0}", maxSum);
        Console.WriteLine("From [{0}] to [{1}]", startIndex, endIndex);
    }
}
