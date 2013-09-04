using System;

class SumOfManyNumbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers would you like to summarize?");
        float numersToSum = Convert.ToSingle(Console.ReadLine());
        float sum = 0;
        float newNum = 0;
        for (float i = 1; i <= numersToSum; i++)
        {
            Console.WriteLine("Enter your digit #{0}: ", i);
            float num = Convert.ToSingle(Console.ReadLine());
            sum = num + newNum;
            newNum = sum;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}