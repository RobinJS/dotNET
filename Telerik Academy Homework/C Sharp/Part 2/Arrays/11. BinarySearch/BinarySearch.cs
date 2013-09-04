// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = { 2, 5, 8, 11, 19, 21, 34, 48};
        int searchFor = 18;
        int maxIndex = arr.Length - 1;
        int minIndex = 0;
        int trialIndex = (minIndex + maxIndex) / 2;

        do
        {
            trialIndex = ((minIndex + maxIndex) / 2);
            if (searchFor < arr[minIndex] || searchFor > arr[maxIndex])
            {
                Console.WriteLine("Index was not found!");
                break;
            }

            else if (searchFor == arr[trialIndex])
            {
                Console.WriteLine("{0} founded at index [{1}]", searchFor, trialIndex);
                break;
            }
            else if (searchFor == arr[maxIndex])
            {
                Console.WriteLine("{0} founded at index [{1}]", searchFor, maxIndex);
                break;
            }
            else if (searchFor > arr[trialIndex])
            {
                minIndex = trialIndex + 1;
            }
            else if (searchFor < arr[trialIndex])
            {
                maxIndex = trialIndex - 1;
            }
            
            if (minIndex == trialIndex)
            {
                Console.WriteLine("Index was not found!");
            }
        }
        while (searchFor != trialIndex && minIndex != trialIndex);
    }
}