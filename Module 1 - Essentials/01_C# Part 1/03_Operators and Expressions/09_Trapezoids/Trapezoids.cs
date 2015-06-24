// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of trapezoid with sides {0}, {1} and height {2} is: {3}", sideA, sideB, height, (sideA + sideB) / 2 * height);
    }
}
