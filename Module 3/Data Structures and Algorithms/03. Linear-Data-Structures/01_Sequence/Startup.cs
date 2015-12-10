// Write a program that reads from the console a sequence of positive integer numbers.
// * The sequence ends when empty line is entered.
// * Calculate and print the sum and average of the elements of the sequence.
// * Keep the sequence in List<int>.

namespace SequenceSumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequenceSumAndAverage
    {
        private const string InputPrompt = "Enter positive integer: ";
        private const string SequenceMessage = "Sequence of positive integers: ";
        private const string NoElementsMessage = "No elements in the sequence";

        public static void Main()
        {
            var sequence = new List<int>();
            string input;

            do
            {
                Console.Write(InputPrompt);
                input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int number;
                while (!int.TryParse(input, out number))
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        break;
                    }

                    Console.Write(InputPrompt);
                    input = Console.ReadLine()?.Trim();
                }

                if (number > 0)
                {
                    sequence.Add(number);
                }
            }
            while (!string.IsNullOrEmpty(input));

            if (sequence.Count == 0)
            {
                Console.WriteLine(NoElementsMessage);
            }
            else
            {
                Console.WriteLine(SequenceMessage + string.Join(", ", sequence));
                Console.WriteLine("Average: " + sequence.Average());
                Console.WriteLine("Sum: " + sequence.Sum());
            }
        }
    }
}