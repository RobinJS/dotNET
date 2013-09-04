using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number: ");
        int entered = Int32.Parse(Console.ReadLine());
        int newNum = entered / 100;
        bool result = (newNum % 10) == 7;
        Console.WriteLine("Integer's third digit right-to-left is 7: " + result);
    }
}
