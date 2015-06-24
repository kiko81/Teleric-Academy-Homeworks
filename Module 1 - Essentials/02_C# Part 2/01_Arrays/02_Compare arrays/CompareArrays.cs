/*
Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter lenght for 1st array = n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght for 2nd array = m: ");
        int m = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[m];

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("Enter value for {0} element of first array: ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < arr2.Length; j++)
        {
            Console.Write("Enter value for {0} element of second array: ", j);
            arr2[j] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;

        if (n != m) areEqual = false;
        else
        {
            for (int k = 0; k < arr1.Length; k++)
            {
                if (arr1[k] != arr2[k])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        Console.WriteLine("The arrays are equal --> {0}", areEqual);
    }
}