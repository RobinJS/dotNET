using System;

class SumAccuracy
{
    static void Main()
    {
        float a = 1f;
        float oldSum = 1f;
        float newSum = 0f;
        for (float i = 2; a / i >= 0.001; i++)
        {
            float fraction = a / i;
            if (i % 2 == 0)
            {
                newSum = oldSum + fraction;
            }
            else
            {
                newSum = oldSum - fraction;
            }
            oldSum = newSum;
        }
        Console.WriteLine(newSum);
    }
}
