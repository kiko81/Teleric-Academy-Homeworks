/*
Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
*/

using System;

class ComparingFloats
{
    static void Main()
    {
        double eps  = 0.000001; 
        Console.Write("Please enter a floating point number: ");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Please enter another floating point number to be compared with the first: ");
        double numB = double.Parse(Console.ReadLine());

        if (Math.Abs(numA - numB) < eps)
        {
            Console.WriteLine("Number {0} and number {1} are equal with precision {2:F10}", numA, numB, eps);
        }
        else
        {
            Console.WriteLine("Number {0} and number {1} are not equal with precision {2:F10}", numA, numB, eps);          
        }
    }
}