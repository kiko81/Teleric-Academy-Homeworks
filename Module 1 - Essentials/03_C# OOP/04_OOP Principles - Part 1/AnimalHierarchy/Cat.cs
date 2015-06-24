namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("meow");
        }
    }
}

