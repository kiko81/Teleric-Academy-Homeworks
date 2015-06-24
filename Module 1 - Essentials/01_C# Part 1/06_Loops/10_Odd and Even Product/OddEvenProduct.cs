/*
Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;
using System.Linq;

class OddEvenProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter n numbers divided by space: ");
        string stringNums = Console.ReadLine();
        int[] numbers = stringNums.Split(' ').Select(int.Parse).ToArray();
        int oddProduct = 1; 
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0) evenProduct *= numbers[i];
            else oddProduct *= numbers[i];
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("Odd product = even product = " + oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Odd product = " + oddProduct);
            Console.WriteLine("Even product = " + evenProduct);               
        } 
    }
}