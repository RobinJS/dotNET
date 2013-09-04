using System;

class SumOfSubsetIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter five integer numbers to see if the sum of some subset of them is 0.");
        Console.Write("Enter integer one: ");
        int inA = Int32.Parse(Console.ReadLine());
        Console.Write("Enter integer two: ");
        int inB = Int32.Parse(Console.ReadLine());
        Console.Write("Enter integer three: ");
        int inC = Int32.Parse(Console.ReadLine());
        Console.Write("Enter integer four: ");
        int inD = Int32.Parse(Console.ReadLine());
        Console.Write("Enter integer five: ");
        int inE = Int32.Parse(Console.ReadLine());
        
        int sum = 0;
        int indexZero = 0;
        int indexOne = 0;
        int indexTwo = 0;
        int indexThree = 0;
        int indexFour = 0;
        int indexX = 0;

        if (sum == inA + inB)
        {
            indexZero = inA;
            indexOne = inB;
            indexX = 2;
        }
        if (sum == inA + inC)
        {
            indexZero = inA;
            indexOne = inC;
            indexX = 2;
        }
        if (sum == inA + inD)
        {
            indexZero = inA;
            indexOne = inD;
            indexX = 2;
        }
        if (sum == inA + inE)
        {
            indexZero = inA;
            indexOne = inE;
            indexX = 2;
        }
        if (sum == inA + inB + inC)
        {
            indexZero = inA;
            indexOne = inB;
            indexTwo = inC;
            indexX = 3;
        }
        if (sum == inA + inB + inD)
        {
            indexZero = inA;
            indexOne = inB;
            indexTwo = inD;
            indexX = 3;
        }
        if (sum == inA + inB + inE)
        {
            indexZero = inA;
            indexOne = inB;
            indexTwo = inE;
            indexX = 3;
        }
        if (sum == inA + inC + inD)
        {
            indexZero = inA;
            indexOne = inC;
            indexTwo = inD;
            indexX = 3;
        }
        if (sum == inA + inC + inE)
        {
            indexZero = inA;
            indexOne = inC;
            indexTwo = inE;
            indexX = 3;
        }
        if (sum == inA + inD + inE)
        {
            indexZero = inA;
            indexOne = inD;
            indexTwo = inE;
            indexX = 3;
        }
        if (sum == inA + inB + inC + inD)
        {
            indexZero = inA;
            indexOne = inB;
            indexTwo = inC;
            indexThree = inD;
            indexX = 4;
        }
        if (sum == inA + inC + inD + inE)
        {
            indexZero = inA;
            indexOne = inC;
            indexTwo = inD;
            indexThree = inE;
            indexX = 4;
        }
        if (sum == inA + inB + inC + inD + inE)
        {
            indexZero = inA;
            indexOne = inB;
            indexTwo = inC;
            indexThree = inD;
            indexFour = inE;
            indexX = 5;
        }
        if (sum == inB + inC)
        {
            indexZero = inB;
            indexOne = inC;
            indexX = 2;
        }
        if (sum == inB + inD)
        {
            indexZero = inB;
            indexOne = inD;
            indexX = 2;
        }
        if (sum == inB + inE)
        {
            indexZero = inB;
            indexOne = inE;
            indexX = 2;
        }
        if (sum == inB + inC + inD)
        {
            indexZero = inB;
            indexOne = inC;
            indexTwo = inD;
            indexX = 3;
        }
        if (sum == inB + inC + inE)
        {
            indexZero = inB;
            indexOne = inC;
            indexTwo = inE;
            indexX = 3;
        }
        if (sum == inB + inD + inE)
        {
            indexZero = inB;
            indexOne = inD;
            indexTwo = inE;
            indexX = 3;
        }
        if (sum == inB + inC + inD + inE)
        {
            indexZero = inB;
            indexOne = inC;
            indexTwo = inD;
            indexThree = inE;
            indexX = 4;
        }
        if (sum == inC + inD)
        {
            indexZero = inC;
            indexOne = inD;
            indexX = 2;
        }
        if (sum == inC + inE)
        {
            indexZero = inC;
            indexOne = inE;
            indexX = 2;
        }
        if (sum == inC + inD + inE)
        {
            indexZero = inC;
            indexOne = inD;
            indexTwo = inE;
            indexX = 3;
        }
        if (sum == inD + inE)
        {
            indexZero = inD;
            indexOne = inE;
            indexX = 2;
        }

        switch (indexX)
        {
            case 2:
                Console.WriteLine("Answer: {0} + {1} = 0", indexZero, indexOne);
                break;
            case 3:
                Console.WriteLine("Answer: {0} + {1} + {2} = 0", indexZero, indexOne, indexTwo);
                break;
            case 4:
                Console.WriteLine("Answer: {0} + {1} + {2} + {3} = 0", indexZero, indexOne, indexTwo, indexThree);
                break;
            case 5:
                Console.WriteLine("Answer: {0} + {1} + {2} + {3} + {4} = 0", indexZero, indexOne, indexTwo, indexThree, indexFour);
                break;
        default:
                Console.WriteLine("The sum of none of these numbers is 0. Try again!");
                break;
        }
    }
}
