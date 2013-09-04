using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Dspace
{
    static class Distance
    {

        static int CalculateDistance(Space3D point1, Space3D point2)
        {
            int distance = Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2) + Math.Pow((point1.Z - point2.Z), 2);

            return distance; 
        }
    }
}
