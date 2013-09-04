// 4. Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class HexadecimalToDecimal
{
    static void Main()
    {
        char[] hexaString = { '1', '0', '1' };

        List<int> hexadecimal = new List<int>();

        foreach (var item in hexaString)
        {
            if ((int)item >= 65 && item <= 70)
            {
                switch ((int)item)
                {
                    case 65:
                        hexadecimal.Add(10);
                        break;
                    case 66:
                        hexadecimal.Add(11);
                        break;
                    case 67:
                        hexadecimal.Add(12);
                        break;
                    case 68:
                        hexadecimal.Add(13);
                        break;
                    case 69:
                        hexadecimal.Add(14);
                        break;
                    case 70:
                        hexadecimal.Add(15);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                hexadecimal.Add((int)item - 48);
            }
        }

        hexadecimal.Reverse();

        double decimalNumber = 0;

        for (int i = 0; i < hexadecimal.Count(); i++)
        {
            decimalNumber += hexadecimal[i] * Math.Pow(16, i);
        }

        Console.WriteLine(decimalNumber);
    }
}
