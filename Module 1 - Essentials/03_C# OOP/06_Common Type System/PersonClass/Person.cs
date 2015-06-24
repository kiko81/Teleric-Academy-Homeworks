namespace PersonClass
{
    using System;

    class Person
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int? age) :this(name)
        {
            this.Age = age;
        }

        public int? Age { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} - {1}", this.Name,
                this.Age != null ? string.Format("Age: " + this.Age) : "no age specified");
        }
    }
}
