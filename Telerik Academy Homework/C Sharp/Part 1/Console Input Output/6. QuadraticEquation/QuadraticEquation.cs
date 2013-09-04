using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("To see the roots ot the quadratic equation \"ax^2+bx+c=0\", please enter three numbers for \"a\", \"b\" and \"c\".");
        Console.WriteLine("Enter a number for \"a\": ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number for \"b\": ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number for \"c\": ");
        double c = Convert.ToDouble(Console.ReadLine());

        double descrim = Math.Pow(b, 2) - (4 * a * c);
        double equationPpositive = (-b + Math.Sqrt(descrim)) / (2 * a);
        double equationNegative = (-b - Math.Sqrt(descrim)) / (2 * a);

        if (descrim < 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (descrim == 0)
        {
            Console.WriteLine("The double root is: " + equationPpositive);
        }
        else if (descrim > 0)
        {

            Console.WriteLine("The roots are: " + equationPpositive + " and " + (equationNegative));
        }
    }
}
