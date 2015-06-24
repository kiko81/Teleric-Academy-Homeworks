/*
Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
*/

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter radius: ");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter of circle with R={0} is {1:f2}", r, Math.PI * 2 * r);
        Console.WriteLine("Area of circle with R={0} is {1:f2}", r, Math.PI * r * r);
    }
}