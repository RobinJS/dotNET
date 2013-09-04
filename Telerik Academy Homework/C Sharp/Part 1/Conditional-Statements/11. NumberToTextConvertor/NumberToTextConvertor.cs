using System;

class NumberToTextConvertor
{
    static void Main()
    {
        Console.WriteLine("This is a number-to-text convertor. Please, enter a number between 0 and 999:");
        while (true)
        {
            ushort userNumber;
            bool numCheck = UInt16.TryParse(Console.ReadLine(), out userNumber);
            double length = Math.Floor(Math.Log10(userNumber)) + 1;
            if (numCheck == false || userNumber > 999 || userNumber < 0)
            {
                Console.WriteLine("Not a valid number!");
            }
            else
            {
                string[] singleDigit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] doubleRoundDigit = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] teen = { "zero", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

                int rounding = userNumber / 10;
                int tens = rounding % 10;
                int ones = userNumber % 10;
                int bigDivision = userNumber % 100; //???
                int hundreds = userNumber / 100;

                if (length == 1 || userNumber == 0)     // if userNumber is a single digit or 0
                {
                    Console.WriteLine("Your number is \"{0}\".", singleDigit[userNumber]);
                }

                if (length == 2)        // if userNumber is a double digit
                {

                    if (userNumber % 10 == 0)       // if userNumber is 10, 20, 30...
                    {
                        Console.WriteLine("Your number is \"{0}\".", doubleRoundDigit[rounding]);
                    }
                    if (userNumber % 10 != 0)       // if userNumber is 15, 26, 38...
                    {
                        if (userNumber >= 20)
                        {
                            Console.WriteLine("Your number is \"{0} {1}\".", doubleRoundDigit[rounding], singleDigit[ones]);
                        }
                        else
                        {
                            Console.WriteLine("Your number is \"{0}\".", teen[ones]);      // if 10 < userNumber < 20
                        }
                    }
                }

                if (length == 3)        // if userNumber is a tripple digit
                {
                    if (tens == 0 & ones == 0)       // if userNumber is a clear hundred: 100, 200, 300...
                    {
                        Console.WriteLine("Your number is \"{0} hundred\".", singleDigit[hundreds]);
                    }
                    if (ones == 0 & tens != 0)       // if userNumber is 510, 620, 830...
                    {
                        Console.WriteLine("Your number is \"{0} hundred and {1}\".", singleDigit[hundreds], doubleRoundDigit[tens]);
                    }
                    if (ones != 0)  // if userNumber is 509, 519, 529
                    {
                        if (tens >= 2)      // if userNumber is 526, 536, 586...
                        {
                            Console.WriteLine("Your number is \"{0} hundred {1} {02}\".", singleDigit[hundreds], doubleRoundDigit[tens], singleDigit[ones]);
                        }
                        if (tens == 1)     // if userNumber is 112, 418...
                        {
                            Console.WriteLine("Your number is \"{0} hundred and {1}\".", singleDigit[hundreds], teen[ones]);
                        }
                        if (tens == 0)
                        {
                            Console.WriteLine("Your number is \"{0} hundred and {1}\".", singleDigit[hundreds], singleDigit[ones]);
                        }
                    }
                }
            }
        }
    }
}
