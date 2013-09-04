using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtilities.GetFileExtension("example"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                TwoDimentionalUtilities.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                ThreeDimentionalUtilities.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Utils.Width = 3;
            Utils.Height = 4;
            Utils.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", ThreeDimentionalUtilities.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", ThreeDimentionalUtilities.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", TwoDimentionalUtilities.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", TwoDimentionalUtilities.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", TwoDimentionalUtilities.CalcDiagonalYZ());
        }
    }
}
