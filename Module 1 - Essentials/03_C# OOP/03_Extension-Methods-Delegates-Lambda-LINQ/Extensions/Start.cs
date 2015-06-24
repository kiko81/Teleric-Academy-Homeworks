namespace Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Start
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder("Some text for testing purposes");
            Console.WriteLine(test.Substring(10, 11)); // [10]^      +11^

            Console.WriteLine();
            Console.WriteLine("Ienumerable extensions");

            IEnumerable<double> testList = new List<double>() { 1, 2, 3, 4, 5, 6 };
            
            Console.WriteLine("Sum: " + testList.Sum());
            Console.WriteLine("Product: " + testList.Product());
            Console.WriteLine("Min: " + testList.Min());
            Console.WriteLine("Max: " + testList.Max());
            Console.WriteLine("Average: " + testList.Average());
        }
    }
}
