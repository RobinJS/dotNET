using System;
using System.Text;

class Triangle
{
    static void Main()
    {
        char copyright = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("    " + copyright);
        Console.WriteLine("  " + "{0} {0} {0}", copyright);
        Console.WriteLine("{0} {0} {0} {0} {0}", copyright);
    }
}