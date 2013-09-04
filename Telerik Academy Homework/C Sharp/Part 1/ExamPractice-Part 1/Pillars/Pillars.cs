using System;

class Pillars
{
    static void Main()
    {
        //byte n0 = Byte.Parse(Console.ReadLine());
        //byte n1 = Byte.Parse(Console.ReadLine());
        //byte n2 = Byte.Parse(Console.ReadLine());
        //byte n3 = Byte.Parse(Console.ReadLine());
        //byte n4 = Byte.Parse(Console.ReadLine());
        //byte n5 = Byte.Parse(Console.ReadLine());
        //byte n6 = Byte.Parse(Console.ReadLine());
        //byte n7 = Byte.Parse(Console.ReadLine());

        byte n0 = 0;
        byte n1 = 64;
        byte n2 = 0;
        byte n3 = 8;
        byte n4 = 0;
        byte n5 = 12;
        byte n6 = 224;
        byte n7 = 0;

        //int mask = 0;
        byte[] b = { n0, n1, n2, n3, n4, n5, n6, n7 };

        byte[] p = { 0, 0, 0, 0, 0, 0, 0, 0 };


        for (int i = 0; i <= 7; i++)
        {
            //string c = Convert.ToString(b[i], 2);

            for (int j = 0; j <= 7; j++)
            {

                //mask = ~mask;
                //int nAndMask = b[i] & mask;
                int mask = 1 << j;
                int nAndMask = b[i] & mask;
                int bit0 = nAndMask >> j;
                if (bit0 == 1)
                {
                    p[j] += 1;
                }
                //int pos[i] = nAndMask >> j;
            }


            Console.WriteLine("{0} - {1}",i, p[i]);


        }
    }
}
