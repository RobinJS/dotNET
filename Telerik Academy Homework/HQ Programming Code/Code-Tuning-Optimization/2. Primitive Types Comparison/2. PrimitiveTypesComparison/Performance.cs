using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _2.PrimitiveTypesComparison
{
    class Performance
    {
        static void Main()
        {
            AddPerformance add = new AddPerformance();
            Console.WriteLine("Add performance:");
            add.PerformAddTest();
            Console.WriteLine();

            SubstractPerformance substract = new SubstractPerformance();
            Console.WriteLine("Substract performance:");
            substract.PerformSubstractTest();
            Console.WriteLine();

            IncrementPerformance increment = new IncrementPerformance();
            Console.WriteLine("Increment performance:");
            increment.PerformIncrementTest();
            Console.WriteLine();

            MultiplyPerformance multiply = new MultiplyPerformance();
            Console.WriteLine("Multiply performance:");
            multiply.PerformMultiplyTest();
            Console.WriteLine();

            DevidePerformance devide = new DevidePerformance();
            Console.WriteLine("Devide performance:");
            devide.PerformDevideTest();
            Console.WriteLine();
        }
    }
}
