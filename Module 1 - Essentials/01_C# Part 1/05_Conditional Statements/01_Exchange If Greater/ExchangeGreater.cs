/*
Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
*/

using System;

class ExchangeGreater
{
    static void Main()
    {
        Console.Write("Write first number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write second number b: ");
        double b = double.Parse(Console.ReadLine());

        double tmp;
        if (a > b)
	    {
            tmp = b;
            b = a;
            a = tmp;
            Console.WriteLine("{0} {1}", a, b);
	    }  
	    else Console.WriteLine("{0} {1}", a, b);
    }
}