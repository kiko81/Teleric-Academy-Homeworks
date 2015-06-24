/*
Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
*/

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("enter array lenght n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Insert element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int counter = 1;
        int bestFreq = 1;
        int freqNumber = array[0];

        for (int j = 1; j < array.Length; j++)
        {
            if (array[j - 1] == array[j])
            {
                counter++;
            }
            else counter = 1;

            if (counter > bestFreq)
            {
                bestFreq = counter;
                freqNumber = array[j];
            }
        }
        Console.WriteLine("{0}({1} times)", freqNumber, bestFreq);
    }
}