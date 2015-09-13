namespace SimpleFactoryDemo
{
    using System;

    public class Health : CheckBook
    {
        public Health()
        {
            Amount = 5000;

            Console.WriteLine("Your Health Expense: {0}", Amount);
        }
    }
}
