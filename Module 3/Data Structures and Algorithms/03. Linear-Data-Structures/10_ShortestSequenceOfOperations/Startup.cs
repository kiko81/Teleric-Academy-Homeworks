// We are given numbers N and M and the following operations:
// 
// N = N+1
// N = N+2
// N = N*2
// 
// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.

namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;

    public class ShortestSequenceOfOperations
    {
        private const string LowerBoundPrompt = "Enter lower bound integer (may be negative): ";
        private const string HigherBoundPrompt = "Enter higher bound (positive) integer greater than the lower: ";

        // Pretty much magic numbers but equal values do different things here so no constants extracted. thats it 
        public static void Main()
        {
            Console.Write(LowerBoundPrompt);
            int lowerBound;
            while (!int.TryParse(Console.ReadLine()?.Trim(), out lowerBound))
            {
                Console.Write(LowerBoundPrompt);
            }

            Console.Write(HigherBoundPrompt);
            int higherBound;
            while (!int.TryParse(Console.ReadLine()?.Trim(), out higherBound) ||
                higherBound < lowerBound ||
                higherBound < 1)
            {
                Console.Write(HigherBoundPrompt);
            }

            var negatives = new Stack<int>();
            while (lowerBound < 0)
            {
                negatives.Push(lowerBound);
                lowerBound += 2;
            }

            var sequence = new Stack<int>();
            sequence.Push(higherBound);
            while (higherBound - 1 > lowerBound)
            {
                while (higherBound - 2 >= lowerBound)
                {
                    while (higherBound / 2 >= lowerBound && higherBound > 2)
                    {
                        if (higherBound % 2 == 1 && higherBound != 3)
                        {
                            higherBound -= 1;
                            sequence.Push(higherBound);
                        }

                        higherBound /= 2;
                        sequence.Push(higherBound);
                    }

                    if (higherBound - 2 >= lowerBound)
                    {
                        higherBound -= 2;
                        sequence.Push(higherBound);
                    }
                }

                if (higherBound - 1 >= lowerBound)
                {
                    higherBound -= 1;
                    sequence.Push(higherBound);
                }
            }

            while (negatives.Count > 0)
            {
                sequence.Push(negatives.Pop());
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}