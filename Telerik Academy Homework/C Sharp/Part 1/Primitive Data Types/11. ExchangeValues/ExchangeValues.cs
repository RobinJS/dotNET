using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before the exchange integer \"a\" is " + a + ", integer \"b\" is " + b + ".");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After the exchange integer \"a\" is " + a + ", integer \"b\" is " + b + ".");
    }
}