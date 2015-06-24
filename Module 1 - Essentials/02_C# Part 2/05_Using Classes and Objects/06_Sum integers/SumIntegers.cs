/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Please enter a sequence of integer numbers, separated by space: ");
        string input = Console.ReadLine();
        int[] nums = input.Split(' ').
            Select(int.Parse).
            ToArray();

        Console.WriteLine(nums.Sum());
    }
}
