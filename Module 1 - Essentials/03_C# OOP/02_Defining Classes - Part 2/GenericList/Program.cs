namespace GenericList
{
    using System;

    class Program
    {
        static void Main()
        {
            var list = new GenericList<int>(7);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Insert(2, 13);

            list.Add(-4);

            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
