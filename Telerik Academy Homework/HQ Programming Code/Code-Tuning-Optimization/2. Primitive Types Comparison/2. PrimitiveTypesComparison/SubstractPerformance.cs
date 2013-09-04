using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _2.PrimitiveTypesComparison
{
    public class SubstractPerformance
    {
        public void PerformSubstractTest()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int resultInt = 1;
            for (int i = 1; i < 10; i++)
            {
                resultInt -= i;
            }
            sw.Stop();
            Console.WriteLine("Result int: {0}", sw.Elapsed);

            sw.Start();
            long resultLong = 1;
            for (int i = 1; i < 10; i++)
            {
                resultLong -= i;
            }
            sw.Stop();
            Console.WriteLine("Result long: {0}", sw.Elapsed);

            sw.Start();
            float resultFloat = 1;
            for (int i = 1; i < 10; i++)
            {
                resultFloat -= i;
            }
            sw.Stop();
            Console.WriteLine("Result float: {0}", sw.Elapsed);

            sw.Start();
            double resultDouble = 1;
            for (int i = 1; i < 10; i++)
            {
                resultDouble -= i;
            }
            sw.Stop();
            Console.WriteLine("Result double: {0}", sw.Elapsed);

            sw.Start();
            decimal resultDecimal = 1;
            for (int i = 1; i < 10; i++)
            {
                resultDecimal -= i;
            }
            sw.Stop();
            Console.WriteLine("Result decimal: {0}", sw.Elapsed);
        }
    }
}
