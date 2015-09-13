namespace SimpleFactoryDemo
{
    using System;

    public class Travel : CheckBook
    {
        public Travel()
        {
            Amount = 10000;

            Console.WriteLine("Your Travel Expense: {0}", Amount);
        }
    }
}
