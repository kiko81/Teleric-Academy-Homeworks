/*
Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Write something to be added to char array 1: ");
        char[] arr1 = Console.ReadLine().ToCharArray();
        Console.Write("Write something to be added to char array 2: ");
        string arr2text = Console.ReadLine();
        int lenght = arr1.Length;
        char[] arr2 = new char[arr2text.Length];

        for (int i = 0; i < arr2text.Length; i++)
        {
            arr2[i] = arr2text[i];
        }
        
        if (arr1.Length != arr2.Length)
        {
            lenght = Math.Min(arr1.Length, arr2.Length);
        }

        bool equal = true;
        for (int j = 0; j < lenght; j++)
        {
            if (arr1[j] > arr2[j])
            {
                Console.WriteLine("First array is first lexicographically ");
                equal = false;
                break;
            }
            else if (arr1[j] < arr2[j])
            {
                Console.WriteLine("Second array is first lexicographically ");
                equal = false;
                break;
            }
            else continue;
        }
        if (equal) Console.WriteLine("Arrays are equal");
    }
}
