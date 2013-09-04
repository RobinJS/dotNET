using System;

namespace _2.PotatoStatements
{
    class Program
    {
        static void Main()
        {
            Potato potato;
            //... 
            if (potato != null)
            {
                if ((potato.HasBeenPeeled) && (potato.IsRotten == false))
                {
                    Cook(potato);
                }
            }

            bool yIsBetweenMaxAndMin = MIN_Y <= y && y <= MAX_Y;
            bool xIsBetweenMaxAndMin = MIN_X <= x && x <= MAX_X;

            if (xIsBetweenMaxAndMin && yIsBetweenMaxAndMin && shouldVisitCell)
            {
               VisitCell();
            }
        }
    }
}
