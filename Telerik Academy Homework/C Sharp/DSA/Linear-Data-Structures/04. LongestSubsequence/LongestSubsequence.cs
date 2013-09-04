//Write a method that finds the longest subsequence of equal numbers
// in given List<int> and returns the result as new List<int>.
//Write a program to test whether the method works correctly.

using System;
using System.Collections.Generic;


public class LongestSubsequence
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 9, 5, -3, 6, -8, 5, -5, 21, 5, 6, -5, 8, -6 };

        List<int> longestSubsequence = FindLongestSubsequence(numbers);

        Print(longestSubsequence);
    }

    public static List<int> FindLongestSubsequence(List<int> numbers)
    {
        int counter = 1;
        int oldCount = 0;
        int repeatingNumber = 0;

        // searching for the maximal sequence
        for (int indexToCompare = 0; indexToCompare < numbers.Count - 1; indexToCompare++)
        {
            for (int currenIndex = indexToCompare + 1; currenIndex < numbers.Count; currenIndex++)
            {
                if (numbers[currenIndex] == numbers[indexToCompare])
                {
                    counter++;
                }
            }

            if (counter > oldCount)
            {
                oldCount = counter;
                repeatingNumber = numbers[indexToCompare];
            }

            counter = 1;
        }

        // initializing the new list with the repeating number
        List<int> newList = new List<int>();
        for (int i = 0; i < oldCount; i++)
        {
            newList.Add(repeatingNumber);
        }

        return newList;
    }

    public static void Print(List<int> longestSubsequence)
    {
        Console.WriteLine("The longes subsequence is:");
        foreach (var integer in longestSubsequence)
        {
            Console.Write(integer + " ");
        }
        Console.WriteLine();
    }
}

