// 7. Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class NumSysConvertor
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userNumber = Console.ReadLine();

        Console.Write("Converting from numeral system (2 to 16): ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Converting to numeral system (2 to 16): ");
        int d = int.Parse(Console.ReadLine());

        int decimalNumber = ConvertToBase10(userNumber, s);

        string result = ConvertToUserChoice(decimalNumber, d);

        PrintResult(result);
    }

    static int ConvertToBase10(string userNumber, int s)
    {
        char[] userNumChar = new char[userNumber.Length];

        for (int i = 0; i < userNumber.Length; i++)
        {
            userNumChar[i] = userNumber[i];
        }

        List<int> temp = new List<int>();

        foreach (var item in userNumChar)
        {
            if ((int)item >= 65 && item <= 70)
            {
                switch ((int)item)
                {
                    case 65:
                        temp.Add(10);
                        break;
                    case 66:
                        temp.Add(11);
                        break;
                    case 67:
                        temp.Add(12);
                        break;
                    case 68:
                        temp.Add(13);
                        break;
                    case 69:
                        temp.Add(14);
                        break;
                    case 70:
                        temp.Add(15);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                temp.Add((int)item - 48);
            }
        }

        temp.Reverse();

        double decimalNumber = 0;

        for (int i = 0; i < temp.Count(); i++)
        {
            decimalNumber += temp[i] * Math.Pow(s, i);
        }

        return (int)decimalNumber;
    }

    static string ConvertToUserChoice(int decimalNumber, int d)
    {
        
        List<string> userChoice = new List<string>();

        do
        {
            int remainder = decimalNumber % d;
            if (remainder >= 10 && remainder <= 15)
            {
                switch ((int)remainder)
                {
                    case 10:
                        userChoice.Add("A");
                        break;
                    case 11:
                        userChoice.Add("B");
                        break;
                    case 12:
                        userChoice.Add("C");
                        break;
                    case 13:
                        userChoice.Add("D");
                        break;
                    case 14:
                        userChoice.Add("E");
                        break;
                    case 15:
                        userChoice.Add("F");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                userChoice.Add(remainder.ToString());
            }

            decimalNumber = decimalNumber / d;
        }
        while (decimalNumber != 0);

        userChoice.Reverse();
        string result = string.Join("", userChoice.ToArray());

        return result;
    }

    static void PrintResult(string result)
    {
        Console.Write("Result: ");
        foreach (char digit in result)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}
