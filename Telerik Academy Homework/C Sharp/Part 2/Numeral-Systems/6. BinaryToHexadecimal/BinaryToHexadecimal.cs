// 6. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinaryToHexadecimal
{
    static void Main()
    {
        string binary = "111110100";

        StringBuilder newBinary = new StringBuilder();  // needed to fix the bug when the binary is not devidable by 4

        int binaryLengthModulus = binary.Length % 4;    // check if the binary is devidable by 4 (for easy convertion)

        if (binaryLengthModulus != 0)   // adding zeros in the beginning of the binary number, if needed
        {
            if (binaryLengthModulus == 1)
            {
                newBinary.Append("000");
            }
            else if (binaryLengthModulus == 2)
            {
                newBinary.Append("00");
            }
            else if (binaryLengthModulus == 3)
            {
                newBinary.Append("0");
            }
        }

        foreach (var item in binary)    // adding the rest of the digits
        {
            newBinary.Append(item);
        }


        StringBuilder hexadecimal = new StringBuilder();

        for (int i = 0; i < newBinary.Length; i = i + 4)
        {
            switch (newBinary.ToString().Substring(i, 4))
            {
                case "0000": hexadecimal.Append("0");
                    break;
                case "0001": hexadecimal.Append("1");
                    break;
                case "0010": hexadecimal.Append("2");
                    break;
                case "0011": hexadecimal.Append("3");
                    break;
                case "0100": hexadecimal.Append("4");
                    break;
                case "0101": hexadecimal.Append("5");
                    break;
                case "0110": hexadecimal.Append("6");
                    break;
                case "0111": hexadecimal.Append("7");
                    break;
                case "1000": hexadecimal.Append("8");
                    break;
                case "1001": hexadecimal.Append("9");
                    break;
                case "1010": hexadecimal.Append("A");
                    break;
                case "1011": hexadecimal.Append("B");
                    break;
                case "1100": hexadecimal.Append("C");
                    break;
                case "1101": hexadecimal.Append("D");
                    break;
                case "1110": hexadecimal.Append("E");
                    break;
                case "1111": hexadecimal.Append("F");
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(hexadecimal.ToString());
    }
}
