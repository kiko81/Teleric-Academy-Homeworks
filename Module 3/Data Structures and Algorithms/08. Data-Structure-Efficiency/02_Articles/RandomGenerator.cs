namespace Articles
{
    using System;

    public class RandomGenerator
    {
        private static Random rand = new Random();

        public int GetRandomInteger(int min = int.MinValue, int max = int.MaxValue)
        {
            return rand.Next(min, max);
        }

        public string GetRandomString(int minLen = 5, int maxLen = 10)
        {
            var stringLen = this.GetRandomInteger(minLen, maxLen);
            var word = string.Empty;

            for (var i = 0; i < stringLen; i++)
            {
                var asciiIndex = this.GetRandomInteger(97, 122);
                var letter = (char)asciiIndex;
                word += letter;
            }

            return word;
        }
    }
}
