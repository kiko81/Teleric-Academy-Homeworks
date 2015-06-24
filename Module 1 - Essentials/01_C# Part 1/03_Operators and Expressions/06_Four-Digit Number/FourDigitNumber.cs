/*
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
*/

using System;

class FourDigitNumber
{
    static void Main()
    {
        
        Input:
        Console.Write("Please enter your 4-digit number: ");
        int num;
        if (!int.TryParse(Console.ReadLine(), out num) || num < 1000 || num > 9999)
        {
            Console.WriteLine("Wrong input number, try again");
            goto Input;
        }

        int num1 = num / 1000;
        int num2 = (num / 100) % 10;
        int num3 = (num / 10) % 10;
        int num4 = num % 10;

        Console.WriteLine("Sum of all digits is: {0}", num1 + num2 + num3 + num4);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", num4, num3, num2, num1);
        Console.WriteLine("Last digit 1st pos.: {0}{1}{2}{3}", num4, num1, num2, num3);
        Console.WriteLine("2nd and 3rd digit positions swapped: {0}{1}{2}{3}", num1, num3, num2, num4);

        
        


    }
}