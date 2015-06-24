/*
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/

using System;

class Div7and5
{
    static void Main()
    {
        Console.Write("Write an integer: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 5 == 0 && num % 7 == 0)
        {
            Console.WriteLine("Number {0} divides to 5 and 7 without remainder", num);
        }
        else
        {
            Console.WriteLine("Number {0} do not divide to 5 and 7", num);
        }
    }
}