// Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DigitsReversion
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        string numbers = Console.ReadLine();

        decimal reversed = ReverseDigits(numbers);

        Console.WriteLine("Reversed: {0}", reversed);
    }

    static decimal ReverseDigits(string numbers)
    {
        List<string> numbersList = new List<string>();

        for (int index = numbers.Length - 1; index >= 0; index--)
        {
            if (numbers[index] != 45)
            {
                numbersList.Add(numbers[index].ToString());
            }
        }

        decimal reversed = decimal.Parse(string.Join("", numbersList));

        return reversed;
    }
}
