namespace School.Client
{
    using System;

    public class RandomGenerator
    {
        private static Random rand = new Random();

        public int GetRandomInteger(int min = int.MinValue, int max = int.MaxValue)
        {
            return rand.Next(min, max + 1);
        }

        public string GetRandomString(int minLen = 5, int maxLen = 10)
        {
            int stringLen = this.GetRandomInteger(minLen, maxLen);
            string word = string.Empty;

            for (int i = 0; i < stringLen; i++)
            {
                var asciiIndex = this.GetRandomInteger(97, 122);
                var letter = (char)asciiIndex;
                word += letter;
            }

            return word;
        }
    }
}
