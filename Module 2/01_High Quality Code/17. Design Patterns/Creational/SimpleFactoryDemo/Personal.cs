namespace SimpleFactoryDemo
{
    using System;

    public class Personal : CheckBook
    {
        public Personal()
        {
            amount = 15000;

            Console.WriteLine("Your Personal Expense: {0}", amount);
        }
    }
}
