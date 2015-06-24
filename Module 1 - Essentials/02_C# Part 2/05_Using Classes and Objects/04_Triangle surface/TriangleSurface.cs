/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
    Side and an altitude to it;
    Three sides;
    Two sides and an angle between them;
Use System.Math.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurface
{
    static void Main()
    {
        Console.Write("side of the triangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("altitude to that side: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine(AreaSideAltitude(a, h));
        Console.WriteLine();
        Console.WriteLine("write 3 sides"); 
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(Area3Sides(a, b, c));
        Console.WriteLine("write 2 sides and angle between them");
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("angle in degrees = ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine(Area2SidesAngle(a, b, c));
    }

    private static double Area2SidesAngle(double a, double b, double c)
    {
        return a * b * Math.Sin(c * Math.PI / 180) / 2;
    }

    private static double Area3Sides(double a, double b, double c)
    {
        double p =(a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p -b) * (p - c));
    }

    private static double AreaSideAltitude(double a, double h)
    {
        return a * h / 2;
    }
}
