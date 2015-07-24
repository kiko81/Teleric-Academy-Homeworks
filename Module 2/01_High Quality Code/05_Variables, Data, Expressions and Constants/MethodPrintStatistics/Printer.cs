namespace MethodPrintStatistics
{
    using System;

    public class Printer
    {
        public void PrintStatistics(double[] array, int count)
        {
            if (array.Length > 0)
            {
                if (count > array.Length)
                {
                    count = array.Length;
                }

                double max = array[0],
                       min = array[0],
                       sum = array[0];

                for (int i = 1; i < count; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }

                    if (array[i] < min)
                    {
                        min = array[i];
                    }

                    sum += array[i];
                }

                Console.WriteLine("Biggest of the first {0} elements: {1}", count, max);
                Console.WriteLine("Smallest of the first {0} elements: {1}", count, min);

                var average = sum / count;

                Console.WriteLine("Average of the first {0} elements: {1}", count, average);
            }
            else
            {
                Console.WriteLine("No elements in array");
            }
            
        }
    }
}
