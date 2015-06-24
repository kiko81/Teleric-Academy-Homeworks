/*
Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;

        Console.WriteLine("Enter 10 numbers in range [{0} - {1}],each next number should be bigger than previous: ", start, end);
        int num = 0;
        int previousNum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0} - ", i);
            num = ReadNumber(start, end, previousNum);            
            previousNum = num;
        }
    }

    private static int ReadNumber(int start, int end, int previousNum)
    {
        int num = 0;
        try
        {
            num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                throw new Exception();
            }
            if (num <= previousNum)
            {
                throw new Exception();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("wrong number");
        }
        return num;
    }
}
