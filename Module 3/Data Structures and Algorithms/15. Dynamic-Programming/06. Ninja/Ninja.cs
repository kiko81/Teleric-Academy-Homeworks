namespace _06.Ninja
{
    using System;

    public class Ninja
    {
        private const int InitStateOn = 1;

        private const int InitStateOff = 0;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            int initState;
            var dp = new int[n];

            // first row, first column = first second
            dp[0] = 1;

            // first row
            for (int col = 1; col < n; col++)
            {
                initState = int.Parse(input[col]);

                if (initState == InitStateOn && (dp[col - 1] % 2) == 1)
                {
                    dp[col] = dp[col - 1] + 1;
                }
                else if (initState == InitStateOff && (dp[col - 1] % 2) == 0)
                {
                    dp[col] = dp[col - 1] + 1;
                }
                else
                {
                    dp[col] = dp[col - 1] + 2;
                }
            }


            for (int row = 1; row < n; row++)
            {
                input = Console.ReadLine().Split(' ');

                // first column
                initState = int.Parse(input[0]);
                if (initState == InitStateOn && (dp[0] % 2) == 1)
                {
                    dp[0] = dp[0] + 1;
                }
                else if (initState == InitStateOff && (dp[0] % 2) == 0)
                {
                    dp[0] = dp[0] + 1;
                }
                else
                {
                    dp[0] = dp[0] + 2;
                }

                // next columns
                for (int col = 1; col < n; col++)
                {
                    initState = int.Parse(input[col]);

                    int fromLeft;
                    if (initState == InitStateOn && (dp[col - 1] % 2) == 1)
                    {
                        fromLeft = dp[col - 1] + 1;
                    }
                    else if (initState == InitStateOff && (dp[col - 1] % 2) == 0)
                    {
                        fromLeft = dp[col - 1] + 1;
                    }
                    else
                    {
                        fromLeft = dp[col - 1] + 2;
                    }

                    int fromUp;
                    if (initState == InitStateOn && (dp[col] % 2) == 1)
                    {
                        fromUp = dp[col] + 1;
                    }
                    else if (initState == InitStateOff && (dp[col] % 2) == 0)
                    {
                        fromUp = dp[col] + 1;
                    }
                    else
                    {
                        fromUp = dp[col] + 2;
                    }

                    dp[col] = fromUp < fromLeft ? fromUp : fromLeft;
                }
            }

            Console.WriteLine(dp[n - 1]);
        }
    }
}
