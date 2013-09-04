using System;

class SignOfRealNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers and the program will show you the sign (+ or -) of the product of these numbers.");
        Console.Write("Enter the first number: ");
        double numOne;
        bool parseOne = Double.TryParse(Console.ReadLine(), out numOne);
        Console.Write("Enter the second number: ");
        double numTwo;
        bool parseTwo = Double.TryParse(Console.ReadLine(), out numTwo);
        Console.Write("Enter the third number: ");
        double numThree;
        bool parseThree = Double.TryParse(Console.ReadLine(), out numThree);
        
        if (parseOne == false || parseTwo == false || parseThree == false)
        {
            Console.WriteLine("You must enter a vialid three numbers!");
        }

        if (numOne < 0 && numTwo < 0 && numThree < 0) // if three -
        {
            Console.WriteLine("The result is \"-\".");
        }
        if (numOne > 0 && numTwo > 0 && numThree > 0)   // if three +
        {
            Console.WriteLine("The result is \"+\".");
        }
        if (numOne < 0 && numTwo > 0 && numThree > 0)   // if A is -
        {
            Console.WriteLine("The result is \"-\".");
        }
        if (numOne > 0 && numTwo < 0 && numThree > 0)   // if B is -
        {
            Console.WriteLine("The result is \"-\".");
        }
        if (numOne > 0 && numTwo > 0 && numThree < 0)   // if C is -
        {
            Console.WriteLine("The result is \"-\".");
        }
        if (numOne < 0 && numTwo < 0 && numThree > 0)   // if A and B are -
        {
            Console.WriteLine("The result is \"+\".");
        }
        if (numOne > 0 && numTwo < 0 && numThree < 0)   // if B and C are -
        {
            Console.WriteLine("The result is \"+\".");
        }
        if (numOne < 0 && numTwo > 0 && numThree < 0)   // if A and C are -
        {
            Console.WriteLine("The result is \"+\".");
        }
    }
}
