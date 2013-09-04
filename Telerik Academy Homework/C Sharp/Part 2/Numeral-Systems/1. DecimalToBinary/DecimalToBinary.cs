// 1. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DecimalToBinary
{
    static void Main()
    {
        int decimalNumber = 500;
        List<int> binaryRepresent = new List<int>();

        do
        {
            int remainder = decimalNumber % 2;
            binaryRepresent.Add(remainder);
            decimalNumber = decimalNumber / 2;
        }
        while (decimalNumber != 0);

        binaryRepresent.Reverse();

        foreach (var item in binaryRepresent)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
