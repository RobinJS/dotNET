// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SortingAnArray
{
    static void Main()
    {
        Console.WriteLine("Enter length for integer array: ");
        int arrLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.WriteLine("Enter element [{0}]", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Your array sorted:");
        foreach (int element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}
