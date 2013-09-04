using System;

class BitBoolean
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number: ");
        int v = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(v, 2).PadLeft(32, '0'));
        Console.WriteLine("Please, enter a number for bit position (counting from 0) to check if it has value of 1: ");
        int p = Int32.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int getBit = vAndMask >> p;
        if (getBit == 1)
        {
            Console.WriteLine("Result: " + true);
        }
        else
        {
            Console.WriteLine("Result: " + false);
        }
    }
}