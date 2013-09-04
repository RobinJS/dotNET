using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _2.PrimitiveTypesComparison
{
    public class IncrementPerformance
    {
        public void PerformIncrementTest()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int resultInt = 1;
            for (int i = 1; i < 10; i++)
            {
                resultInt++;
            }
            sw.Stop();
            Console.WriteLine("Result int: {0}", sw.Elapsed);

            sw.Start();
            long resultLong = 1;
            for (int i = 1; i < 10; i++)
            {
                resultLong++;
            }
            sw.Stop();
            Console.WriteLine("Result long: {0}", sw.Elapsed);

            sw.Start();
            float resultFloat = 1;
            for (int i = 1; i < 10; i++)
            {
                resultFloat++;
            }
            sw.Stop();
            Console.WriteLine("Result float: {0}", sw.Elapsed);

            sw.Start();
            double resultDouble = 1;
            for (int i = 1; i < 10; i++)
            {
                resultDouble++;
            }
            sw.Stop();
            Console.WriteLine("Result double: {0}", sw.Elapsed);

            sw.Start();
            decimal resultDecimal = 1;
            for (int i = 1; i < 10; i++)
            {
                resultDecimal++;
            }
            sw.Stop();
            Console.WriteLine("Result decimal: {0}", sw.Elapsed);
        }
    }
}
