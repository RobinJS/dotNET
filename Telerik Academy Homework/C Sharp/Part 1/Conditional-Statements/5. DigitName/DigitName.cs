using System;

    class DigitName
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive digit 0 - 9 to see it's name.");
            while (true)
            {
                short number = Convert.ToInt16(Console.ReadLine());
                switch (number)
                {
                    case 0: Console.WriteLine("You entered \"zero\"."); break;
                    case 1: Console.WriteLine("You entered \"one\"."); break;
                    case 2: Console.WriteLine("You entered \"two\"."); break;
                    case 3: Console.WriteLine("You entered \"three\"."); break;
                    case 4: Console.WriteLine("You entered \"four\"."); break;
                    case 5: Console.WriteLine("You entered \"five\"."); break;
                    case 6: Console.WriteLine("You entered \"six\"."); break;
                    case 7: Console.WriteLine("You entered \"seven\"."); break;
                    case 8: Console.WriteLine("You entered \"eight\"."); break;
                    case 9: Console.WriteLine("You entered \"nine\"."); break;
                    default: Console.WriteLine("Not a valid number!"); break;
                }
            }
        }
    }
