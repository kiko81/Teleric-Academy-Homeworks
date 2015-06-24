/*
Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Linq;
using System.Numerics;
using System.Text;

class NumberAsArray
{
    static Random r = new Random();

    static void Main()
    {
        //the methods do nothing unless arrays given
            // for testing - anyway if you want to see something reasonable reduce 10001 to sth smaller 

        //int[] array1 = Enumerable
        //    .Repeat(0, r.Next(1, 10001))
        //    .Select(i => r.Next(10))
        //    .ToArray();
        //Console.WriteLine("1st array: {" + string.Join(", ", array1) + "}");

        //int[] array2 = Enumerable
        //    .Repeat(0, r.Next(1, 10001))
        //    .Select(i => r.Next(10))
        //    .ToArray();
        //Console.WriteLine("2nd array: {" + string.Join(", ", array2) + "}");
        
        //Console.WriteLine(AddDigitArraysReversed(array1, array2));
        
    }

    private static BigInteger AddDigitArraysReversed(int[] array1, int[] array2)
    {
        BigInteger number1 = BigInteger.Parse(ArrayToString(array1));
        BigInteger number2 = BigInteger.Parse(ArrayToString(array2));
        BigInteger result = number1 + number2;
        return result;
    }

    private static string ArrayToString(int[] array)
    {
        Array.Reverse(array);
        StringBuilder numAsString = new StringBuilder();
        foreach (int value in array)
        {
            numAsString.Append(value);
        }
        return numAsString.ToString();
    }
}
