using System;
//using System.Text;

class PrintASCIItable
{
    static void Main()
    {
        //Console.OutputEncoding = Encoding.UTF8;
        int i;
        for (i = 0; i < 256; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}
