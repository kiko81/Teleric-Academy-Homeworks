namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w,h)
        {
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
