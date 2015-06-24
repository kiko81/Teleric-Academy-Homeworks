/*
Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
*/
// no switch case applicable because no integer value conditioned

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score value: ");
        double score = double.Parse(Console.ReadLine());

        if (score >= 1 && score <=3)
        {
            Console.WriteLine("Bonus score is {0}", score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.WriteLine("Bonus score is {0}", score * 100);
        }
        else if (score >= 7 && score <= 9)
        {
            Console.WriteLine("Bonus score is {0}", score * 1000);
        }
        else if (score > 9 || score < 1)
        {
            Console.WriteLine("Invalid score");
        }
        else Console.WriteLine("No condition - no bonus: {0}", score);
    }
}