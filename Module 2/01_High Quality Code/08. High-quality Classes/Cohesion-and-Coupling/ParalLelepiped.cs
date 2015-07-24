using System;

namespace CohesionAndCoupling
{
    public class Parallelepiped
    {
        private double height;
        private double width;
        private double depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth should be positive number");
                }

                this.depth = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be positive number");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be positive number");
                }

                this.height = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CoordinateUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);

            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CoordinateUtils.CalcDistance2D(0, 0, this.Width, this.Height);

            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CoordinateUtils.CalcDistance2D(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CoordinateUtils.CalcDistance2D(0, 0, this.Height, this.Depth);

            return distance;
        }
    }
}
