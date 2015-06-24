/*
Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Quadratic Equation ax*x+bx+c");
        Console.Write("Please enter the a number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the b number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the c number: ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;
        if (d < 0)
        {
            Console.WriteLine("No real roots");
        }
        else
        {
            Console.WriteLine("The roots are: x1={0:f2}, x2={1:f2}", -b - Math.Sqrt(d) / (2 * a), -b + Math.Sqrt(d) / (2 * a));    
        } 
    }
}