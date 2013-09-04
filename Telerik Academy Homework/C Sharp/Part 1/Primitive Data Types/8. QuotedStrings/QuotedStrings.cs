using System;

class QuotedStrings
{
    static void Main()
    {
        string notQuoted = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(notQuoted);
        Console.WriteLine(quoted);
    }
}
