// Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below: x2 + 5 = 1x2 + 0x + 5 -> 501

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Polynomials
{
    static void Main()
    {
        int[] P1 = { 9, 4 };
        int[] P2 = { -2, 8, -1 };

        int[] resultAdd = PolynomialsAddition(P1, P2);
        int[] resultSub = PolynomialsSubstraction(P1, P2);
        int[] resultMulty = PolynomialsMultiplication(P1, P2);

        Console.WriteLine("Addition result: ");
        PrintResult(resultAdd);
        Console.WriteLine();

        Console.WriteLine("Substraction result: ");
        PrintResult(resultSub);
        Console.WriteLine();

        Console.WriteLine("Multiplication result: ");
        PrintResult(resultMulty);
        Console.WriteLine();
    }

    static int[] PolynomialsAddition(int[] P1, int[] P2)
    {
        List<int> polyAdd = new List<int>();

        if (P1.Length > P2.Length)
        {
            for (int i = 0; i < P2.Length; i++)
            {
                polyAdd.Add(P1[i] + P2[i]);
            }

            for (int i = P2.Length; i < P1.Length; i++)
            {
                polyAdd.Add(P1[i]);
            }
        }
        else if (P1.Length < P2.Length)
        {
            for (int i = 0; i < P1.Length; i++)
            {
                polyAdd.Add(P1[i] + P2[i]);
            }

            for (int i = P1.Length; i < P2.Length; i++)
            {
                polyAdd.Add(P2[i]);
            }
        }
        else if (P1.Length == P2.Length)
        {
            for (int i = 0; i < P1.Length; i++)
            {
                polyAdd.Add(P1[i] + P2[i]);
            }
        }
        return polyAdd.ToArray();
    }

    static int[] PolynomialsSubstraction(int[] P1, int[] P2)
    {
        List<int> polySub = new List<int>();

        if (P1.Length > P2.Length)
        {
            for (int i = 0; i < P2.Length; i++)
            {
                polySub.Add(P1[i] - P2[i]);
            }

            for (int i = P2.Length; i < P1.Length; i++)
            {
                polySub.Add(P1[i]);
            }
        }
        else if (P1.Length < P2.Length)
        {
            for (int i = 0; i < P1.Length; i++)
            {
                polySub.Add(P1[i] - P2[i]);
            }

            for (int i = P1.Length; i < P2.Length; i++)
            {
                polySub.Add(P2[i]);
            }
        }
        else if (P1.Length == P2.Length)
        {
            for (int i = 0; i < P1.Length; i++)
            {
                polySub.Add(P1[i] - P2[i]);
            }
        }
        return polySub.ToArray();
    }

    static int[] PolynomialsMultiplication(int[] P1, int[] P2)
    {
        int[] polyMulty = new int[P1.Length + P2.Length];

        for (int i = 0; i < P1.Length; i++)
        {
            for (int j = 0; j < P2.Length; j++)
            {
                polyMulty[i + j] = polyMulty[i + j] + P1[i] * P2[j];
            }
        }

        return polyMulty;
    }

    static void PrintResult(int[] resultAdd)
    {
        for (int i = resultAdd.Length - 1; i > 0; i--)
        {
            if (resultAdd[i] > 0)
            {
                Console.Write("+ {0}x^{1} ", resultAdd[i], i);
            }
            else if (resultAdd[i] < 0)
            {
                Console.Write("- {0}x^{1} ", Math.Abs(resultAdd[i]), i);
            }
        }
        if (resultAdd[0] > 0)
        {
            Console.Write("+ {0}", resultAdd[0]);
        }
        else if (resultAdd[0] < 0)
        {
            Console.Write("{0}", resultAdd[0]);
        }
        Console.WriteLine();
    }
}