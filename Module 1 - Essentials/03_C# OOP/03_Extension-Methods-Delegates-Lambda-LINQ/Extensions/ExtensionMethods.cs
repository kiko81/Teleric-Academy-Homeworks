namespace Extensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ExtensionMethods
    {
        //problem 1
        public static StringBuilder Substring(this StringBuilder input, uint index, uint length)
        {
            StringBuilder result = new StringBuilder();

            if (index >= input.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index + length >= input.Length)
            {
                throw new ArgumentException("The substring goes beyond the string");
            }

            for (uint i = index; i < index + length; i++)
            {
                result.Append(input[(int)i]);
            }

            return result;
        }

        public static T Sum<T>(this IEnumerable<T> input)
        {
            dynamic result = 0;

            foreach (var item in input)
            {
                result += item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> input)
        {
            dynamic result = 1;

            foreach (var item in input)
            {
                result *= item;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            T min = input.First();

            foreach (var item in input)
            {
                if (item.CompareTo(min) < 0) min = item;                  
            }
                
            return min;
        }
        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            T max = input.First();

            foreach (var item in input)
            {
                if (item.CompareTo(max) > 0) max = item;
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> input)
        {

            return (dynamic)input.Sum() / input.Count();
        }





    }
}

