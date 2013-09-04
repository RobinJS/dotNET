using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SmallProgram
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\tWhich task would you like to solve?");
            Console.WriteLine(" - To reverse the digits of a number, enter 1\n - To calculate the average of a sequence of integers, enter 2\n - To solve a linear equation a * x + b = 0, enter 3\n - To exit, enter 4.");
            Console.WriteLine();

            byte userChoice = 0;
            do
            {
                try
                {
                    userChoice = Convert.ToByte(Console.ReadLine());
                    if (userChoice > 0 && userChoice <= 4)
                    {
                        switch (userChoice)
                        {
                            case 1:
                                decimal reversed = ReverseDigits();
                                Console.WriteLine("Reversed: {0}", reversed);
                                Console.WriteLine();
                                break;
                            case 2:
                                decimal average = CalculateAverage();
                                Console.WriteLine("The average: {0}", average);
                                Console.WriteLine();
                                break;
                            case 3:
                                decimal linearEquation = CalculateLinearEquation();
                                Console.WriteLine("Linear equation result: : {0}", linearEquation);
                                Console.WriteLine();
                                break;
                            case 4:
                                goto programEnd;
                                
                            default:
                                Console.WriteLine("Not a valid number!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please, enter 1, 2 or 3 to choose an action!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter a valid integer number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please, enter a non-negative number (1, 2 or 3)!");
                }
            } while (userChoice < 1 || userChoice > 3);
        }

    programEnd:
        Console.WriteLine("Good bye!");
    }

    static decimal ReverseDigits()
    {
        Console.Write("Please enter a positive number at least 2 digits long to be reversed: ");
        decimal numToReverse = 0;
        decimal reversed = 0;

        while (numToReverse > decimal.MaxValue || numToReverse < 10)
        {
            try
            {
                numToReverse = decimal.Parse(Console.ReadLine());
                if (numToReverse.ToString().Length < 2)
                {
                    Console.WriteLine("You must enter a non-negative number at least 2 digits long!");
                }
                else if (numToReverse < 0)
                {
                    Console.WriteLine("You must enter a non-negative number!");
                }
                else
                {
                    List<string> numbersList = new List<string>();

                    for (int index = numToReverse.ToString().Length - 1; index >= 0; index--)
                    {
                        numbersList.Add(numToReverse.ToString()[index].ToString());
                    }

                    reversed = decimal.Parse(string.Join("", numbersList));
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too big!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an integer number!");
            }
        }
        return reversed;
    }

    static decimal CalculateAverage()
    {
        Console.Write("Please enter how many integers would you like to calculate: ");

        int sequenceCount = 1;
        while (sequenceCount > 0)
        {
            try
            {
                sequenceCount = int.Parse(Console.ReadLine());

                if (sequenceCount <= 0)
                {
                    Console.WriteLine("You must enter a non-negative integer number bigger than zero!");
                }
                else
                {
                    break;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too big!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid integer number!");
            }
        }

        int[] sequenceOfNumbers = new int[sequenceCount];

        for (int i = 0; i < sequenceCount; i++)
        {
            while (sequenceOfNumbers[i] == 0)
            {
                try
                {
                    Console.Write("Enter #{0}: ", i + 1);

                    sequenceOfNumbers[i] = int.Parse(Console.ReadLine());

                    if (sequenceOfNumbers[i] == 0)
                    {
                        Console.WriteLine("You must enter an integer number other than zero!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number you entered is too big!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter an integer number!");
                }
            }
        }

        decimal result = 0;

        for (int i = 0; i < sequenceOfNumbers.Length; i++)
        {
            result += sequenceOfNumbers[i];
        }

        result = result / sequenceOfNumbers.Length;

        return result;
    }

    static decimal CalculateLinearEquation()
    {
        Console.WriteLine("To solve the equation a * x + b = 0, enter \"a\" and \"b\".");

        decimal a = 0;
        decimal b = 0;

        while (a == 0)
        {
            try
            {
                Console.Write("Enter \"a\": ");

                a = decimal.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("You must enter a number other than zero!");
                }
                else
                {
                    break;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too big!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an integer number!");
            }
        }

        while (b == 0)
        {
            try
            {
                Console.Write("Enter \"b\": ");

                b = decimal.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("You must enter a number other than zero!");
                }
                else
                {
                    break;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too big!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an integer number!");
            }
        }
        
        Console.WriteLine("You entered: {0} * x + {1} = 0", a, b);

        decimal x = -b / a;
        return x;
    }
}
