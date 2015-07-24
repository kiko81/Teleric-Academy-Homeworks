namespace SearchInBits
{
    using System;

    public class SearchInBits
    {
        private const int PatternToInt = 15;
        private const int BinaryCharsOfSearchedNumber = 30;
        private const int LengthOfSearchedPattern = 4;    

        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int numberOfSearches = BinaryCharsOfSearchedNumber - LengthOfSearchedPattern;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int j = 0; j <= numberOfSearches; j++)
                {
                    if (((number >> j) & PatternToInt) == (s & PatternToInt))
                    {
                        counter++;
                    }
                } 
            }


            Console.WriteLine(counter);
        }
    }
}