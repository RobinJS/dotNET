using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int p = Int32.Parse(Console.ReadLine());

            string oldP = Convert.ToString(p, 2);
            string pStr = "";
            int mask = 1;
            int pTemp = p;

            for (int j = 1; j <= oldP.Length; j++)
            {
                if ((pTemp & mask) == 1)
                {
                    pStr += "1";
                }
                if ((pTemp & mask) == 0)
                {
                    pStr += "0";
                }
                pTemp = pTemp >> 1;
            }

            int pInverted = Convert.ToInt32(pStr, 2);
            int pNew = (p ^ ~p) & pInverted;

            Console.WriteLine(pNew);
        }
    }
}
