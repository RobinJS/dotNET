using System;
using System.Collections.Generic;
using System.Text;

namespace _2.StatisticsCalculation
{
    class StatisticsCalculation
    {
        static void Main(string[] args)
        {
        }

        public void PrintStatistics(double[] numbers, int numbersCount)
        {
            double maxNumber = FindMaxNumber(numbers, numbersCount);
            double averageNumber = FindAverageNumber(numbers, numbersCount);
        }

        private static double FindMaxNumber(double[] numbers, int numbersCount)
        {
            double maxNumber = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            for (int i = 0; i < numbersCount; i++)
            {
                if (numbers[i] < maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        private static double FindAverageNumber(double[] numbers, int numbersCount)
        {
            double numberValues = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                numberValues += numbers[i];
            }

            double averageNumber = numberValues / numbersCount;
            return averageNumber;
        }
    }
}


