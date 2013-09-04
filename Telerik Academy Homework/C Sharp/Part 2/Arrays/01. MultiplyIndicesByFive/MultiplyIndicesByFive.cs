// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

using System;

class MultiplyIndicesByFive
{
    static void Main()
    {
        int[] intArray = new int[20];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i * 5;
        }

        foreach (int element in intArray)
        {
            Console.WriteLine(element);
        }
    }
}