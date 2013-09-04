// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class EratosthenesAlgorithm
{
    static void Main()
    {
        // creating a List with numbers
        List<int> numList = new List<int>();
        int p = 1;
        while (p <= 10000000)
        {
            numList.Add(p);
            p++;
        }

        // setting a stop for fast calcutation
        int checkStop = (int)Math.Sqrt(numList.Count);

        // clearing the List from non-Primes
        for (int i = 2; i <= checkStop; i++)
        {
            if (numList[i] > 0)
            {
                for (int j = i * i; j < numList.Count; j += i)
                {
                    numList[j] = 0;
                }
            }
        }

        // printing result
        for (int i = 1; i < numList.Count; i++)
        {
            if (numList[i] > 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
