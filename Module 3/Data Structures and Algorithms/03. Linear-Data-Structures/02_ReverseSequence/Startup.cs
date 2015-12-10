// Write a program that reads N integers from the console and reverses them using a stack.
// * Use the Stack<int> class.

namespace ReverseSequence
{
    using System;
    using System.Collections.Generic;

    public class ReverseSequence
    {
        private const string InputPrompt = "Enter some integers, separated by space: ";
        private const string ReverseMessage = "Reversed: ";

        public static void Main()
        {
            Console.Write(InputPrompt);

            var input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write(InputPrompt);
                input = Console.ReadLine();
            }

            var values = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<string>();
            foreach (var value in values)
            {
                stack.Push(value);
            }

            Console.Write(ReverseMessage);
            while (stack.Count > 0)
            {
                var output = stack.Pop();
                Console.Write(output);
                if (stack.Count > 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}