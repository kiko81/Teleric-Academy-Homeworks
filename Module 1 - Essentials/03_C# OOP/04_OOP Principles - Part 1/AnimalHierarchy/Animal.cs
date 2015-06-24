
namespace AnimalHierarchy
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Gender gender)
            : this(name, age)
        {
            this.Gender = gender;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public Gender Gender { get; protected set; }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public abstract void Sound();

        public override string ToString()
        {
            return string.Format("{0}: {1}, age:{2} - {3}", this.GetType().Name.ToLowerInvariant(), this.Name, this.Age, this.Gender.ToString().ToUpper()[0]);
        }

        public static double CalculateAvgAge(IEnumerable<Animal> list)
        {
            double result = list.Average(x => x.Age);
            
            return result;
        }
    }
}
