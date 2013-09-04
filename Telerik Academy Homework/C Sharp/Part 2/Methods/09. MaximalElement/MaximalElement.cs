// Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaximalElement
{
    static void Main()
    {
        int[] numArray = { 8, 5, 13, 21, 4, 6, 3, 9, 16 };

        int intervalStart = 0;
        int intervalEnd = 2;

        int maxElement = ReturnMaximalElement(numArray, intervalStart, intervalEnd);

        numArray = SortArrayAscending(numArray);

        PrintResults(numArray, maxElement, intervalStart, intervalEnd);
    }

    static int ReturnMaximalElement(int[] numArray, int intervalStart, int intervalEnd)
    {
        int[] newArr = new int[(intervalEnd - intervalStart) + 1];

        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = numArray[i + intervalStart];
        }

        int maxElement = newArr.Max();

        return maxElement;
    }

    static int[] SortArrayAscending(int[] numArray)
    {
        for (int i = 0; i < numArray.Length - 1; i++)
        {
            for (int j = i + 1; j < numArray.Length; j++)
            {
                if (numArray[i] > numArray[j])
                {
                    int temp = numArray[i];
                    numArray[i] = numArray[j];
                    numArray[j] = temp;
                }
            }
        }
        return numArray;
    }

    static void PrintResults(int[] numArray, int maxElement, int intervalStart, int intervalEnd)
    {
        Console.WriteLine("The maximal element from index [{0}] to index [{1}] of the array is \"{2}\".", intervalStart, intervalEnd, maxElement);
        Console.WriteLine("Array sorted:");

        foreach (int number in numArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
