/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

using System;

class AppearanceCount
{
    static Random r = new Random();

    static void Main()
    {
        Console.Write("enter number to search - {0-10} : ");
        int number = int.Parse(Console.ReadLine());

        //test case
        int[] array = new int[r.Next(number, 100)];
        for (int i = 0; i < array.Length; i++)
        {
            //bigger chance of appearances - not surely anyway
            array[i] = r.Next(0, (int)Math.Sqrt(array.Length)); 
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("number {0} appears {1} times in the array", number, CountApps(number, array));

    }

    private static int CountApps(int number, int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number) counter++;
        }
        return counter;
    }
}
