namespace PersonClass
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static void Main()
        {
            var persons = new List<Person>
            {
                new Person("Ivan"),
                new Person("Dragan", 33)
            };

            Console.WriteLine(string.Join(Environment.NewLine, persons));
        }
    }
}
