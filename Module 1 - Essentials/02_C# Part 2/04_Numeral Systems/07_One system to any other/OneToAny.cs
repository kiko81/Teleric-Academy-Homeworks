/*
Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OneToAny
{
    static void Main()
    {
        char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        Console.Write("Enter base system (2-16): ");
        int fromBase = int.Parse(Console.ReadLine());
        Console.Write("Enter a number in {0} system. Allowed symbols: {1}", fromBase, string.Join(", ", array.Take(fromBase)));
        string inputNumber = Console.ReadLine().ToUpper();
        Console.Write("Enter target system (2-16): ");
        int toBase = int.Parse(Console.ReadLine());

        long decimalNumber = ToDecimal(inputNumber, fromBase);
        string result = FromDecimal(decimalNumber, toBase);

        Console.WriteLine("Initial number: {0}\nThe number in the target system: {1}",
            inputNumber, result);
    }

    static long ToDecimal(string number, int fromBase)
    {
        long result = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(number[i]))
            {
                result += int.Parse(number[i].ToString()) * (long)Math.Pow(fromBase, number.Length - i - 1);
            }
            else
            {
                result += (number[i] - 'A' + 10) * (long)Math.Pow(fromBase, number.Length - i - 1);
            }
        }
        return result;
    }

    static string FromDecimal(long number, int toBase)
    {
        string result = "";
        if (number == 0)
        {
            result = "0";
        }
        else
        {
            while (number > 0)
            {
                if (number % toBase < 10)
                {
                    result = number % toBase + result;
                }
                else
                {
                    result = (char)(number % toBase + 'A' - 10) + result;
                }
                number /= toBase;
            }
        }
        return result;
    }
}