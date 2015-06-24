/*
Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Write how many Fibonacci members you want to see: ");
        int n = int.Parse(Console.ReadLine());
        int firstNum = 0;
        int secondNum = 1;
        
        if (n == 0)
        {
            Console.WriteLine("You choosed 0");
        }
        else
        {
            int thirdNum = 0;
            Console.Write("{0}, ", firstNum);
            for (int i = 1; i <= n - 1; i++)
            {
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = firstNum + secondNum;
                Console.Write("{0}, ", thirdNum);
            }
            Console.WriteLine();
        }
        


    }
}