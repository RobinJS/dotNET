// 2. Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinaryToDecimal
{
    static void Main()
    {
        int[] binaryNumber = { 1, 1, 0, 1, 1, 0 };
        Array.Reverse(binaryNumber);

        double decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += binaryNumber[i] * Math.Pow(2, i);
        }

        Console.WriteLine(decimalNumber);
    }
}
