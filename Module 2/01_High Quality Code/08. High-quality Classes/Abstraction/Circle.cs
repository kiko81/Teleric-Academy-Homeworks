using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0d)
                {
                    throw new ArgumentOutOfRangeException("Radius must be positive number");
                }
                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
