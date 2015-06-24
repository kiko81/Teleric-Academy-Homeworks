namespace Shapes
{
    using System;

    public class Start
    {
        static void Main()
        {
            var shapes = new Shape[]
            {
                new Triangle(5, 4),
                new Rectangle(5, 6),
                new Square(6),
                new Circle(20)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine("Surface of {0} with width {1}, height {2} = {3}", item.GetType().Name.ToLower(), item.Width, item.Height, item.CalculateSurface());
            }
        }
    }
}
