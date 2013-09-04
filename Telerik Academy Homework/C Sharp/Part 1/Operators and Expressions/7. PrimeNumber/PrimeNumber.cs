using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number from 0 to 100 to check if it is prime or not: ");
        uint entered = uint.Parse(Console.ReadLine());
        uint i;
        uint math = (uint)Math.Sqrt(entered);
        bool prime = true;
        for (i = 2; i < 100; i++)
        {
            if (prime && (i <= math))
            {
                if (entered % i == 0)
                {
                    prime = false;
                }
            }
        }
        Console.WriteLine(prime);
    }
}
