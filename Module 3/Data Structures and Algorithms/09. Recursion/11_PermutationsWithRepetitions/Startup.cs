// Write a program to generate all permutations with repetitionsof given multi-set.namespace 

namespace PermutationsWithRepetitions
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var arr = new[] { 1, 3, 5, 5 };
            // arr = new[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            Array.Sort(arr);
            PermuteRep(arr, 0, arr.Length);
        }

        public static void PermuteRep(int[] arr, int start, int n)
        {
            Print(arr);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                var firstElement = arr[left];
                for (var i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[n - 1] = firstElement;
            }
        }

        public static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        public static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
