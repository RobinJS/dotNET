using System;

class ModifyingABit
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer number: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, select a bit position (counting from 0) to change: ");
        int p = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter 0 or 1 to change the selected bit: ");
        int v = Int32.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int nAndMask = n & mask;
            Console.WriteLine("Results: ");
            Console.WriteLine("Bit representation of the entered integer: \r\n" + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Bits after the modification: \r\n" + Convert.ToString(nAndMask, 2).PadLeft(32, '0'));
            Console.WriteLine("New integer: " + nAndMask + "\r\n");
        }
        else if (v == 1)
        {
            int mask = (1 << p);
            int nAndMask = n | mask;
            Console.WriteLine("Results: ");
            Console.WriteLine("Bit representation of the entered integer: \r\n" + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Bits after the modification: \r\n" + Convert.ToString(nAndMask, 2).PadLeft(32, '0'));
            Console.WriteLine("New integer: " + nAndMask + "\r\n");
        }
    }
}
