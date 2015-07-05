namespace VariablePrinter
{
    using System;

    public class Printer
    {
        private const int MaxCount = 6;

        public void Print(bool value)
        {
            string valueToString = value.ToString();
            Console.WriteLine(valueToString);
        }
    }
}
