// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArraysComparison
{
    static void Main()
    {
        Console.WriteLine("To compare two arrays of chars, first enter their length.");
        Console.Write("Array One length: ");
        int arrOneLength = int.Parse(Console.ReadLine());
        Console.Write("Array Two length: ");
        int arrTwoLength = int.Parse(Console.ReadLine());

        char[] arrOne = new char[arrOneLength];
        char[] arrTwo = new char[arrTwoLength];
        char[] firstArr = new char[0];
        char[] secondArr = new char[0];
        bool equal = false;

        // initializing array One
        for (int index = 0; index < arrOneLength; index++)
        {
            Console.Write("Enter element {0} of array One: ", index);
            arrOne[index] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        // initializing array Two
        for (int index = 0; index < arrTwoLength; index++)
        {
            Console.Write("Enter element {0} of array Two: ", index);
            arrTwo[index] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        // comparing arrays
        if (arrOneLength != arrTwoLength)   // if both arrays have different length, the shortest comes first
        {
            if (arrOneLength < arrTwoLength)
            {
                firstArr = arrOne;
                secondArr = arrTwo;
                equal = false;
            }
            else if (arrOneLength > arrTwoLength)
            {
                firstArr = arrTwo;
                secondArr = arrOne;
                equal = false;
            }
        }
        else // if both arrays have the same length, arrange them in lexicographical order
        {
            for (int i = 0; i < arrOneLength; i++)
            {
                if (arrOne[i] < arrTwo[i])
                {
                    firstArr = arrOne;
                    secondArr = arrTwo;
                    equal = false;
                    break;
                }
                else if (arrOne[i] > arrTwo[i])
                {
                    firstArr = arrTwo;
                    secondArr = arrOne;
                    equal = false;
                    break;
                }
                else
                {
                    equal = true;
                }
            }
        }

        // printing arrays
        if (equal == true)
        {
            Console.WriteLine("Both arrays are equal.");
        }
        else if (equal == false)
        {
            for (int index = 0; index < firstArr.Length; index++)
            {
                Console.Write("{0} ", firstArr[index]);
            }
            Console.WriteLine();
            for (int index = 0; index < secondArr.Length; index++)
            {
                Console.Write("{0} ", secondArr[index]);
            }
        }
        Console.WriteLine();
    }
}
