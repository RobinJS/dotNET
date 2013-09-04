// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class AddingNumbers
{
    static void Main()
    {
        byte[] firstArray = { 5, 3, 2, 4, 6, 5, 4, 6, 5, 3, 1, 6, 5, 4, 6, 8, 9 };
        byte[] secondArray = { 3, 5, 4, 5, 8, 7, 4, 6, 5, 4 };

        AddNumbers(firstArray, secondArray);
    }

    static void AddNumbers(byte[] firstArray, byte[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        BigInteger firstNumber = BigInteger.Parse(string.Join("", firstArray));
        BigInteger secondNumber = BigInteger.Parse(string.Join("", secondArray));

        BigInteger result = firstNumber + secondNumber;
        Console.WriteLine(result);
    }
}