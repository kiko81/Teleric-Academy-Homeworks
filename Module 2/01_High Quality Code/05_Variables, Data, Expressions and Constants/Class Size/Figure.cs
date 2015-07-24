namespace ClassSize
{
    using System;

    public class Figure
    {
        private double width, height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Figure GetRotatedFigure(Figure figure, double rotationAngle)
        {
            var newWidth = Math.Abs(Math.Cos(rotationAngle) * figure.width)
                           + Math.Abs(Math.Sin(rotationAngle) * figure.height);
            var newHeight = Math.Abs(Math.Sin(rotationAngle) * figure.width)
                            + Math.Abs(Math.Cos(rotationAngle) * figure.height);

            return new Figure(newWidth, newHeight);
        }
    }
}