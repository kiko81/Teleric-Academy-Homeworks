// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("coordinate on x axis - x: ");
        double xAxis = double.Parse(Console.ReadLine());
        Console.Write("coordinate on y axis - y: ");
        double yAxis = double.Parse(Console.ReadLine());
        Console.Write("Radius (default 2) - K{0,0} ");
        double radius = double.Parse(Console.ReadLine());
        if (Math.Sqrt(xAxis * xAxis + yAxis * yAxis) <= radius)
        {
            Console.WriteLine("The point with coordinates x:{0}, y:{1} is in the circle K({{0, 0}}, {2})", xAxis, yAxis, radius);
        }
        else
        {
            Console.WriteLine("The point with coordinates x:{0}, y:{1} is not in the circle with radius {2}", xAxis, yAxis, radius);
        }
    }
}