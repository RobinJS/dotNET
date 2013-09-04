using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Dspace
{
    public class Space3D
    {
        public struct Point3D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
        }

        public Point3D point { get; set; }

        public Space3D(Point3D point)
        {
            this.point = point;
        }

        public override string ToString()
        {
            string pointAsString = string.Format(
                "Point X: {0}, point Y: {1}, point Z: {2}",
                this.point.X, this.point.Y, this.point.Z);
            return pointAsString;
        }

        private static readonly Point3D sytemStart = new Point3D() { X = 0, Y = 0, Z = 0 };

        public static Point3D ReturnPointZero()
        {
            return sytemStart;
        }


        static void Main()
        {
            Space3D point1 = new Space3D(
                new Point3D() { X = 2, Y = 4, Z = 6 }
                );
            Space3D point2 = new Space3D(
                new Point3D() { X = 1, Y = 3, Z = 5 }
                );

            Console.WriteLine(point1);
            

            


        }
    }
}
