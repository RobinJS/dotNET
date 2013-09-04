// 8. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryOf16BitShort
{
    static void Main()
    {
        short decimalNumber = 100;

        if (decimalNumber >= 0)
        {
            string binary = "";
            int temp = decimalNumber;

            for (int i = 0; i <= 15; i++)
            {
                if (temp % 2 == 0)
                {
                    binary = "0" + binary;
                }
                else
                {
                    binary = "1" + binary;
                }
                temp = temp / 2;
            }

            Console.WriteLine(binary);
        }
        else if (decimalNumber < 0)
        {
            string binary = "";

            int temp = int.MinValue - decimalNumber;

            for (int i = 0; i <= 15; i++)
            {
                if (temp % 2 == 0)
                {
                    binary = "0" + binary;
                }
                else
                {
                    binary = "1" + binary;
                }
                temp = temp / 2;
            }

            Console.WriteLine(binary);
        }

    }
}
