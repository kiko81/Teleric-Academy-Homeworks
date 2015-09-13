namespace SimpleFactoryDemo
{
    using System;

    public class Personal : CheckBook
    {
        public Personal()
        {
            Amount = 15000;

            Console.WriteLine("Your Personal Expense: {0}", Amount);
        }
    }
}
