namespace ThreeNumbers
{
    using System;

    public class ThreeNumbers
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long max = long.MinValue;
            long min = long.MaxValue;

            long sum = a + b + c;

            if (a >= b & a >= c)
            {
                max = a;
            }
            else if (b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            if (a <= b & a <= c)
            {
                min = a;
            }
            else if (b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:f2}", (double)sum / 3);
        }
    }
}