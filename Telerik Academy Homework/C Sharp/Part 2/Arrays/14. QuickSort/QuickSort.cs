// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class quicksort
{
    static void Main()
    {
        List<string> arrayOfStrings = new List<string> { "opel", "toyota", "bmw", "ferrari", "porsche", "wv", "lexus", "lada" };

        arrayOfStrings = Quicksort(arrayOfStrings);

        PrintStrings(arrayOfStrings);
    }

    // sorting the strings
    static List<string> Quicksort(List<string> arrayOfStrings)
    {
        if (arrayOfStrings.Count <= 1)
        {
            return arrayOfStrings;
        }

        string pivot = arrayOfStrings[arrayOfStrings.Count - 1];

        List<string> less = new List<string>();
        List<string> greater = new List<string>();

        for (int index = 0; index < arrayOfStrings.Count; index++)
        {
            if (arrayOfStrings[index].CompareTo(pivot) < 0)
            {
                less.Add(arrayOfStrings[index]);
            }
            else if (arrayOfStrings[index].CompareTo(pivot) > 0)
            {
                greater.Add(arrayOfStrings[index]);
            }
        }

        arrayOfStrings = ConcatenateArrayParts(Quicksort(less), Quicksort(greater), pivot);

        return arrayOfStrings;
    }

    // Concatinating list parts in new sorted list
    static List<string> ConcatenateArrayParts(List<string> less, List<string> greater, string pivot)
    {
        less.Add(pivot);

        foreach (string str in greater)
        {
            less.Add(str);
        }

        return less;
    }

    // Printing the sorted list
    static void PrintStrings(List<string> arrayOfStrings)
    {
        foreach (var str in arrayOfStrings)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}