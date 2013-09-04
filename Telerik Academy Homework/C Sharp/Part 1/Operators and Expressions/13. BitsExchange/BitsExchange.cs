using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary: " + "{0,39}",Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Positions we are looking for: -----111------------------111---".PadLeft(61));
        
        // getting bits 3, 4 and 5
        uint firstMask = 7 << 3;
        uint nAndfirstMask = n & firstMask;
        Console.WriteLine("Getting bits 3, 4 and 5: " + "{0,37}", Convert.ToString(nAndfirstMask, 2).PadLeft(32, '0'));
        
        // getting bits 24, 25 and 26
        uint secondMask = 7 << 24;
        uint nAndSecondMAsk = n & secondMask;
        Console.WriteLine("Getting bits 24, 25 and 26: " + "{0,34}", Convert.ToString(nAndSecondMAsk, 2).PadLeft(32, '0'));
        
        // changing groups positions
        uint firstGroup = nAndfirstMask << 21;
        uint secondGroup = nAndSecondMAsk >> 21;
        Console.WriteLine("Two groups exchanged: " + "{0,40}", Convert.ToString(firstGroup | secondGroup, 2).PadLeft(32, '0'));

        // making n positions empty
        uint grouping = ~(firstMask | secondMask);
        uint clearedN = n & grouping;

        // showing result
        uint newN = clearedN | firstGroup | secondGroup;
        Console.WriteLine("Bits after exchange: " + "{0,41}", Convert.ToString(newN, 2).PadLeft(32, '0'));
        Console.WriteLine("New number: " + newN);
    }
}