namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("bark");
        }
    }
}
