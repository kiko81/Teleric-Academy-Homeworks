using System;

namespace ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main()
        {
            bool isEnd = false;

            while (!isEnd)
            {
                long result = 1;

                for (long k = 0; k < 10; k++)
                {
                    string number = Console.ReadLine();
                    long numValue = 1;

                    if (number == "END")
                    {
                        isEnd = true;
                        break;
                    }
                    else
                    {
                        long numberLenght = number.Length;
                        long num = Convert.ToInt64(number);

                        for (long j = 0; j < numberLenght; j++)
                        {
                            long x;
                            x = num % 10;
                            num /= 10;
                            if (x != 0) numValue *= x;

                        }

                        if (k % 2 == 1)
                        {
                            result *= numValue;
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}