// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Rectangle width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Rectangle height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter of rectangle with width {0} and height {1} is:{2}", width, height, 2 * (width + height));
    }
}