/*
Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
*/

using System;

class MinMaxSumAverage
    {
        static void Main()
        {
            Console.WriteLine("Enter number count n: ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter integer value: ");
                int number = int.Parse(Console.ReadLine());

                sum += number;
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine("Smallest - {0}", min);
            Console.WriteLine("Biggest - {0}", max);
            Console.WriteLine("Sum - {0}", sum);
            Console.WriteLine("Average - {0:f2}", (double)sum / (double)n);
        }
    }