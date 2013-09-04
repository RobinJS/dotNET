using System;

class TypeCasting
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concate = hello + " " + world;
        string newString = (string)concate;
        Console.WriteLine(newString);
    }
}
