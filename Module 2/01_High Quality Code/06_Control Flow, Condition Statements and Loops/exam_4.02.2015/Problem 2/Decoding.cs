namespace Decoding
{
    using System;

    public class Decoding
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            string txt = Console.ReadLine();
            char[] text = txt.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                decimal value = text[i];

                if (value >= 48 && value <= 57)
                {
                    value += salt + 500;
                    value = OddOrEven(i, value);
                }
                else if ((value >= 65 && value <= 90) || (value >= 97 && value <= 122))
                {
                    value = value * salt + 1000;
                    value = OddOrEven(i, value);
                }
                else if (value == 64)
                {
                    break;
                }
                else
                {
                    value -= salt;
                    value = OddOrEven(i, value);
                }
            }
        }

        private static decimal OddOrEven(int i, decimal value)
        {
            if (i % 2 == 0)
            {
                value /= 100;

                Console.WriteLine("{0:f2}", value);
            }
            else
            {
                value *= 100;

                Console.WriteLine(value);
            }
            return value;
        }
    }
}