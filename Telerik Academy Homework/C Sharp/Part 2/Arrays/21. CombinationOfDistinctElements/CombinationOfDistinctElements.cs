// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Collections.Generic;

class CombinationOfDistinctElements
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int N = 5;//int.Parse(Console.ReadLine());
        Console.Write("Enter a number for K: ");
        int K = 2;//int.Parse(Console.ReadLine());
        Console.WriteLine();

        // creating elements
        List<int> elements = new List<int>();
        for (int i = 0; i < K; i++)
        {
            elements.Add(1);
        }

        try
        {
            while (true)
            {
                int currentIndex = K - 1;
                for (int i = 1; i < K; i++)
                {
                    if (elements[currentIndex] != elements[currentIndex - 1] && elements[currentIndex - 1] < elements[currentIndex])
                    {
                        // printing elements
                        Console.Write("{");
                        foreach (int item in elements)
                        {
                            Console.Write("{0}, ", item);
                        }
                        Console.Write("\b\b}");
                        Console.WriteLine();
                    }
                }

                // creating variations
                while (elements[currentIndex] == N)
                {
                    elements[currentIndex] = currentIndex + 1;
                    currentIndex -= 1;
                }

                elements[currentIndex]++;
                currentIndex = K - 1;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine();
        }
    }
}
