/*
Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Second Number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Third Number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("The biggest number is: ");
        Console.WriteLine(GetMax(GetMax(a, b), c));
    }

    static int GetMax(int x, int y)
    {
        int bigger = Math.Max(x, y);
        return bigger;
    }
}