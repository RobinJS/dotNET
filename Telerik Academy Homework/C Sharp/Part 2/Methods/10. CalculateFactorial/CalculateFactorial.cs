// Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class CalculateFactorial
{
    static void Main()
    {
        int[] numbersArr = new int[100];

        for (int i = 0; i < numbersArr.Length; i++)
        {
            numbersArr[i] = i + 1;
        }

        FactorialCalculate(numbersArr);
    }

    static void FactorialCalculate(int[] numbersArr)
    {
        foreach (int index in numbersArr)
        {
            BigInteger factorial = 1;

            int currentNum = index;
            do
            {
                factorial *= currentNum;
                currentNum--;
            }
            while (currentNum > 0);
            Console.WriteLine("{0}! is {1}", index, factorial);
            Console.WriteLine();
        }
    }
}