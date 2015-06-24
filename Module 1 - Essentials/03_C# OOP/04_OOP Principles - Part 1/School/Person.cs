namespace School
{
    public abstract class Person
    {
        private string name;

        protected Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
