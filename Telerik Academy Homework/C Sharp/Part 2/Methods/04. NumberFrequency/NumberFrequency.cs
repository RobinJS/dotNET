// Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class NumberFrequency
{
    static void Main()
    {
        int[] intArray = { 4, 1, 1, 4, 2, 3, 1, 2, 4, 9, 3, 2, 2, 1, 1 };

        //Sorting array
        Array.Sort(intArray);

        int first = intArray[0];
        int next = 0;
        int length = 1;
        int bestLength = 0;
        int end = 0;

        // searching for the maximal sequence
        for (int i = 1; i < intArray.Length; i++)
        {
            next = intArray[i];
            if (first == intArray[i])
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

        // printing info
        Console.WriteLine("The most frequent number is: {0}", intArray[end]);
        Console.WriteLine("It is repeating {0} times.", bestLength);
    }
}
