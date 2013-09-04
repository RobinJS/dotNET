// Write a method that returns the last digit of given integer as an English word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LastDigitAsWord
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        string number = Console.ReadLine();

        ReturnWord(number);
    }

    static void ReturnWord(string number)
    {
        char lastNum = number[number.Length - 1];

        Console.Write("The last digit is ");

        switch (lastNum)
        {
            case '0': Console.WriteLine("ZERO");
                break;
            case '1': Console.WriteLine("ONE");
                break;
            case '2': Console.WriteLine("TWO");
                break;
            case '3': Console.WriteLine("THREE");
                break;
            case '4': Console.WriteLine("FOUR");
                break;
            case '5': Console.WriteLine("FIVE");
                break;
            case '6': Console.WriteLine("SIX");
                break;
            case '7': Console.WriteLine("SEVEN");
                break;
            case '8': Console.WriteLine("EIGHT");
                break;
            case '9': Console.WriteLine("NINE");
                break;
            default: Console.WriteLine("not a number!");
                break;
        }
    }
}
