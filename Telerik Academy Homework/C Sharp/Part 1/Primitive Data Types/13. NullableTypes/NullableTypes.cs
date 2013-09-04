using System;

class NullableTypes
{
    static void Main()
    {
        int? ni = null;
        Console.WriteLine(ni);
        ni = 3;
        Console.WriteLine(ni);
        double? nd = null;
        Console.WriteLine(nd);
        nd = 5;
        Console.WriteLine(nd);
    }
}