//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortArrayByLength
{
    static void Main()
    {
        string[] arrStrings = { "You", "are", "given", "an", "array", "of", "strings" };

        arrStrings = SortArray(arrStrings);

        PrintSortedArray(arrStrings);
    }

    static string[] SortArray(string[] arrStrings)
    {
        int[] sized = new int[arrStrings.Length];

        for (int index = 0; index < sized.Length; index++)
        {
            sized[index] = arrStrings[index].Length;
        }

        Array.Sort(sized, arrStrings);
        return arrStrings;
    }

    static void PrintSortedArray(string[] arrStrings)
    {
        for (int i = 0; i < arrStrings.Length; i++)
        {
            Console.Write("{0} ", arrStrings[i]);
        }
        Console.WriteLine();
    }
}
