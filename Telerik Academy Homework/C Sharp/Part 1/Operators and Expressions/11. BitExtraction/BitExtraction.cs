using System;

class BitExtraction
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number: ");
        int i = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter a number for bit position (counting from 0) to see it's value: ");
        int b = Int32.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        int getBit = iAndMask >> b;
        Console.WriteLine("Result: " + getBit);
        Console.WriteLine(Convert.ToString(i, 2).PadLeft(32, '0'));
    }
}
