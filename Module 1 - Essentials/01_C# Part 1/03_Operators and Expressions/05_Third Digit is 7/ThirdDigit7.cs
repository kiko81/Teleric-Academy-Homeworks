// Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;


class ThirdDigit7
{
    static void Main()
    {
        Console.Write("Enter number to check: ");
        int number = int.Parse(Console.ReadLine());
        
        bool isSeven = ((number / 100) % 10 == 7);
        Console.WriteLine("Number {0}'s third digit from right-to-left is 7 - {1}", number, isSeven);
    }
}