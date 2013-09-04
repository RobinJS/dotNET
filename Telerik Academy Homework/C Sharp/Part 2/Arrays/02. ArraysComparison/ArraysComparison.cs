// Write a program that reads two arrays from the console and compares them element by element.

using System;

class ArraysComparison
{
    static void Main()
    {
        Console.WriteLine("To compare two arrays of integers, first enter the length of array One:");
        int arrOneLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the length of array Two:");
        int arrTwoLength = int.Parse(Console.ReadLine());

        if (arrOneLength != arrTwoLength)
        {
            Console.WriteLine("The arrays are not equal.");
        }
        else
        {
            int[] arrOne = new int[arrOneLength];
            int[] arrTwo = new int[arrTwoLength];

            // initializing array One
            for (int index = 0; index < arrOneLength; index++)
            {
                Console.Write("Enter element [{0}] of array One: ", index);
                arrOne[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // initializing array Two
            for (int index = 0; index < arrTwoLength; index++)
            {
                Console.Write("Enter element [{0}] of array Two: ", index);
                arrTwo[index] = int.Parse(Console.ReadLine());
            }

            // comparing arrays
            bool equal = true;
            for (int i = 0; i < arrTwoLength; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    equal = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The arrays are equal?: {0}", equal);
        }
    }
}