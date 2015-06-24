/*
Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
*/

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        int minus = 0;
        string sign;

        if (a < 0)
        {
            minus++;
        }
        if (b < 0)
        {
            minus++;
        }
        if (c < 0)
        {
            minus++;
        }
        if (minus % 2 == 0)
        {
            sign = "+";
        }
        else
        {
            sign = "-";
        }
        if (a == 0 || b == 0 || c == 0)
        {
            sign = "0";
        }
        Console.WriteLine("The sign after multiplication of these three numbers will be \"{0}\"", sign);
    }
}