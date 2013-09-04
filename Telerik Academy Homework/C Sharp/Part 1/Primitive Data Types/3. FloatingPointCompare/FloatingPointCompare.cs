using System;

class FloatingPointCompare
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.01f;
        bool compareAB = (a == b);
        Console.WriteLine(compareAB);
        float c = 5.00000001f;
        float d = 5.00000003f;
        bool compareCD = (c == d);
        Console.WriteLine(compareCD);
    }
}