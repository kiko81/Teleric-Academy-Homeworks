/*
Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;

class MaximalSequence
{
    static void Main()
    {
        string input = Console.ReadLine();  // "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        string[] array = input.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

        string element = "";
        string bestElement = "";
        int sequence = 1;
        int bestSequence = 1;

        for (int j = 1; j < array.Length - 1; j++)
        {
            if (array[j - 1] == array[j])
            {
                sequence++;
                element = array[j];
            }
            else sequence = 1;

            if (sequence > bestSequence)
            {
                bestSequence = sequence;
                bestElement = element;
            }
        }

        for (int k = 0; k < bestSequence; k++)
        {
            Console.Write(bestElement);
            if (k != bestSequence - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}