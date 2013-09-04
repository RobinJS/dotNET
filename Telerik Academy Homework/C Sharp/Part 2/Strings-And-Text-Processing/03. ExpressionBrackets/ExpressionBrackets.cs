/* 3. Write a program to check if in a given expression the brackets are put correctly.
 *  Example of correct expression: ((a+b)/5-d).
 *  Example of incorrect expression: )(a+b)).
*/
using System;

namespace _03.ExpressionBrackets
{
    class ExpressionBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter some expression to check if the brackets are put correctly:");
            string expression = Console.ReadLine();
            //string expression = ")(a+b))";

            int bracketIndexer = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    bracketIndexer++;
                }
                else if (expression[i] == ')')
                {
                    bracketIndexer--;
                }

                if (bracketIndexer < 0)
                {
                    break;
                }
            }

            if (bracketIndexer == 0)
            {
                Console.WriteLine("The brackets are put correctly.");
            }
            else
            {
                Console.WriteLine("The brackets are not put correctly.");
            }
        }
    }
}
