/*
Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
*/

using System;

class RandomNumsInRange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter min value: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Enter n numbers: ");
            int n = int.Parse(Console.ReadLine());

            if (min > max) SwapValues(ref min, ref max);
            
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(rnd.Next(min, max) + " ");
            }
            Console.WriteLine();
        }

        private static void SwapValues(ref int min, ref int max)
        {
            min ^= max;
            max ^= min;
            min ^= max;
        }
    }