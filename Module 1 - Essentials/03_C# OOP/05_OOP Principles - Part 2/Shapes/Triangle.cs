namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double w, double h) : base(w,h)
        {
        }

        public override double CalculateSurface()
        {
            return Width * Height / 2;
        }
    }
}
