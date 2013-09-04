// Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

using System;

class MaximalSumOfElements
{
    static void Main()
    {
        // entering data
        Console.WriteLine("Enter length for integer array: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for how many elements to be summarized: ");
        int K = int.Parse(Console.ReadLine());

        int[] intArr = new int[N];

        for (int index = 0; index < N; index++)
        {
            Console.Write("Enter element {0} of the array: ", index);
            intArr[index] = int.Parse(Console.ReadLine());
        }

        int sum;
        int maximalSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int currentIndex = 0;

        // searching for the maximal sum
        for (int index = 0; index < N - (K - 1); index++)
        {
            sum = 0;
            for (currentIndex = index; currentIndex < K + index; currentIndex++)
            {
                sum += intArr[currentIndex];
            }
            
            if (sum > maximalSum)
            {
                maximalSum = sum;
                startIndex = index;
                endIndex = currentIndex - 1;
            }
        }

        // printing info
        Console.WriteLine();
        Console.WriteLine("The maximal sum is: {0}", maximalSum);
        Console.WriteLine("From index[{0}] to index[{1}] of the array", startIndex, endIndex);
        Console.Write("Which are the numbers: ");

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", intArr[i]);
        }
        Console.WriteLine();
    }
}
