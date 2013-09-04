// 5. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class HexadecimalToBinary
{
    static void Main()
    {
        char[] hexaArr = { '1', '8', '5', 'A' };

        List<string> binaryList = new List<string>();

        foreach (char digit in hexaArr)
        {
            switch (digit)
            {
                case '1':
                    binaryList.Add("0001");
                    break;
                case '2':
                    binaryList.Add("0010");
                    break;
                case '3':
                    binaryList.Add("0011");
                    break;
                case '4':
                    binaryList.Add("0100");
                    break;
                case '5':
                    binaryList.Add("0101");
                    break;
                case '6':
                    binaryList.Add("0110");
                    break;
                case '7':
                    binaryList.Add("0111");
                    break;
                case '8':
                    binaryList.Add("1000");
                    break;
                case '9':
                    binaryList.Add("1001");
                    break;
                case 'A':
                    binaryList.Add("1010");
                    break;
                case 'B':
                    binaryList.Add("1011");
                    break;
                case 'C':
                    binaryList.Add("1100");
                    break;
                case 'D':
                    binaryList.Add("1101");
                    break;
                case 'E':
                    binaryList.Add("1110");
                    break;
                case 'F':
                    binaryList.Add("1111");
                    break;
                default:
                    break;
            }
        }

        string binaryRepresentation = String.Join("", binaryList.ToArray());
        Console.WriteLine(binaryRepresentation);
    }
}
