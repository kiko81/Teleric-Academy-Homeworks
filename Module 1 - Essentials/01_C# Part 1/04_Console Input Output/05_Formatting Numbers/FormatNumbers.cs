/*
Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;

class FormatNumbers
{
    static void Main()
    {
        Input:
        Console.Write("Please enter the first number: ");
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || (a < 0) || (a > 500))
        {
            Console.WriteLine("Wrong input. Please enter integer 0 <= a <= 500");
            goto Input;
        }
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Output: \n{0}|{1}|{2,10:f2}|{3,-10:f3}|", a.ToString("X").PadRight(10, ' '), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        
    }
}