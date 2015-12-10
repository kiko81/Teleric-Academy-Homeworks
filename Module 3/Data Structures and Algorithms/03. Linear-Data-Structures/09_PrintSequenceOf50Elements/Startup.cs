// We are given the following sequence:
// 
// S1 = N;
// S2 = S1 + 1;
// S3 = 2* S1 + 1;
// S4 = S1 + 2;
// S5 = S2 + 1;
// S6 = 2* S2 + 1;
// S7 = S2 + 2;
// 
// Using the Queue<T> class write a program to print its first 50 members for given N.

namespace PrintSequenceOf50Elements
{
    using System;
    using System.Collections.Generic;

    public class PrintSequence
    {
        private const string InputPrompt = "Enter number to begin from: ";
        private const int NumberOfElements = 50;

        public static void Main()
        {
            Console.Write(InputPrompt);
            var input = Console.ReadLine()?.Trim();
            int n;
            while (string.IsNullOrEmpty(input) || !int.TryParse(input, out n))
            {
                Console.Write(InputPrompt);
                input = Console.ReadLine()?.Trim();
            }

            var container = new Queue<int>();
            container.Enqueue(n);
            var result = new List<int>();

            while (result.Count < NumberOfElements)
            {
                var currentBase = container.Dequeue();
                result.Add(currentBase);

                if (container.Count <= NumberOfElements - result.Count)
                {
                    container.Enqueue(currentBase + 1);
                    container.Enqueue((2 * currentBase) + 1);
                    container.Enqueue(currentBase + 2);
                }
                else
                {
                    while (container.Count > 0 && result.Count < NumberOfElements)
                    {
                        result.Add(container.Dequeue());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
