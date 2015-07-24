namespace PersianRugs
{
    using System;

    public class PersianRugs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2 * n + 1; i++)
            {
                for (int j = 0; j < 2 * n + 1; j++)
                {
                    if (i == n && j == n)
                    {
                        Console.Write('X');
                    }
                    else if (i == j)
                    {
                        Console.Write('\\');
                    }
                    else if (i == 2 * n - j)
                    {
                        Console.Write('/');
                    }
                    else if (j <= i - 1 && i <= n)
                    {
                        Console.Write('#');
                    }
                    else if (i > n && j > i)
                    {
                        Console.Write('#');
                    }
                    else if (i > n && j < 2 * n + 1 - i)
                    {
                        Console.Write('#');
                    }
                    else if (i <= n && j > 2 * n - i)
                    {
                        Console.Write('#');
                    }
                    else if (j == i + 1 + d &&
                             i < n - d - 1 &&
                             2 * d + 5 <= 2 * n - 1)
                    {
                        Console.Write('\\');
                    }
                    else if (j == 2 * n - 1 - d - i &&
                             i < n - d - 1 &&
                             2 * d + 5 <= 2 * n - 1)
                    {
                        Console.Write('/');
                    }
                    else if (j == i - 1 - d &&
                             i > n + d + 1 &&
                             2 * d + 5 <= 2 * n - 1)
                    {
                        Console.Write('\\');
                    }
                    else if (j == 2 * n + 1 + d - i &&
                             i > n + d + 1 &&
                             2 * d + 5 <= 2 * n - 1)
                    {
                        Console.Write('/');
                    }
                    else if (j > i + 1 + d &&
                             j < 2 * n - 1 - d - i &&
                             i < n - d - 1 &&
                             2 * d + 5 <= 2 * n - 1)
                    {
                        Console.Write('.');
                    }
                    else if (j < i - 1 - d &&
                             j > 2 * n + 1 + d - i &&
                             i > n + d + 1 &&
                             2 * d + 5 <= 2 * n - 1)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}