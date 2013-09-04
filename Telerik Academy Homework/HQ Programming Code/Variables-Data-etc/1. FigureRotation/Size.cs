using System;

namespace _1.FigureRotation
{
    public class Size
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Size GetRotatedSize(Size figureSize, double figureAngle)
        {
            double figureSinus = Math.Abs(Math.Sin(figureAngle));
            double figureCosinus = Math.Abs(Math.Cos(figureAngle));
            double rotatedWidth = figureCosinus * figureSize.Width + figureSinus * figureSize.Height;
            double rotatedHeight = figureSinus * figureSize.Width + figureCosinus * figureSize.Height;
            return new Size(rotatedWidth, rotatedHeight);
        }
    }
}