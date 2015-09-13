namespace SimpleFactoryDemo
{
    using System;

    public class SimpleFactoryDemo
    {
        static void Main()
        {
            Console.WriteLine("Type 1 for Personal expense:");
            Console.WriteLine("Type 2 for Travel expense:");
            Console.WriteLine("Type any number for Health expense:");
            string input = Console.ReadLine();

            CheckFactory checkFactory = new CheckFactory();
            CheckBook currentExpense = checkFactory.ChooseExpense(int.Parse(input));
            Console.WriteLine("Call from parent class " + currentExpense.GetExpense());

        }
    }
}
