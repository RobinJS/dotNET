using System;

class Sum
{
    static void Main()
    {
        Console.WriteLine("Please, enter the first integer number: ");
        int firstInt = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the second integer number: ");
        int secondInt = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the third integer number: ");
        int thirdInt = Int32.Parse(Console.ReadLine());
        int sum = firstInt + secondInt + thirdInt;
        Console.WriteLine("The sum of the three entered numbers is: {0}", sum);
    }
}
