﻿/*
Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        int c = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The sum of three numbers is {0}", a + b + c);
    }
}