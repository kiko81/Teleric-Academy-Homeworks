using System;
namespace Shapes
{
    class Circle : Square
    {
        public Circle(double r) : base(r)
        {
            this.Width = r;
        }

        public override double CalculateSurface()
        {
            return base.CalculateSurface() * Math.PI / 4;
        }
    }
}
