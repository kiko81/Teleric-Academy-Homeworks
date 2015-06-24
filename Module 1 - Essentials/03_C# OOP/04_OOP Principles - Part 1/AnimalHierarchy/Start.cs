namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static void Main()
        {
            var animals = new List<List<Animal>>();

            var dogs = new List<Animal>
            {
                new Dog("Sharo", 5, Gender.male),
                new Dog("Laika", 7, Gender.female)
            };

            animals.Add(dogs);

            var frogs = new List<Animal>
            {
                new Frog("Kermit", 33, Gender.male),
                new Frog("Queen", 24, Gender.female)
            };

            animals.Add(frogs);

            var cats = new List<Animal>
            {
                new Kitten("Missy", 3),
                new Tomcat("Macko", 4),
                new Kitten("Pisana", 8),
                new Tomcat("Rambo", 1),
                new Cat("Pisan", 13)
            };

            animals.Add(cats);

            Console.WriteLine("List of all animals:");

            foreach (var animal in animals)
            {
                foreach (var item in animal)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Dogs average age: " + Animal.CalculateAvgAge(dogs));
            Console.WriteLine("Frogs average age: " + Animal.CalculateAvgAge(frogs));
            Console.WriteLine("Cats average age: " + Animal.CalculateAvgAge(cats));



           
        }
    }
}
