using System;

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number: ");
        int entered = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Entered number in binary: " + Convert.ToString(entered, 2).PadLeft(32, '0'));
        int mask = 1 << 3;
        int enteredAndMask = entered & mask;
        int bit = enteredAndMask >> 3;
        if (bit == 1)
        {
            Console.WriteLine("Bit 3 (counting from 0) of the entered integer is: 1");
        }
        else if (bit == 0)
        {
            Console.WriteLine("Bit 3 (counting from 0) of the entered integer is: 0");
        }
    }
}
