// 3. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber = 3214;
        List<string> hexadecimal = new List<string>();

        do
        {
            int remainder = decimalNumber % 16;
            if (remainder >= 10 && remainder <= 15)
            {
                switch (remainder)
                {
                    case 10:
                        hexadecimal.Add("A");
                        break;
                    case 11:
                        hexadecimal.Add("B");
                        break;
                    case 12:
                        hexadecimal.Add("C");
                        break;
                    case 13:
                        hexadecimal.Add("D");
                        break;
                    case 14:
                        hexadecimal.Add("E");
                        break;
                    case 15:
                        hexadecimal.Add("F");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                hexadecimal.Add(remainder.ToString());
            }

            decimalNumber = decimalNumber / 16;
        }
        while (decimalNumber != 0);

        hexadecimal.Reverse();

        foreach (string digit in hexadecimal)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}
