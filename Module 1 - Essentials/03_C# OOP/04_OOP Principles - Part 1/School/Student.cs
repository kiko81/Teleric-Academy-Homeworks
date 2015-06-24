namespace School
{
    public class Student : Person, ICommentable
    {
        private int ucn; // UniqueClassNumber

        public Student(string name, int ucn)
            : base(name)
        {
            this.UCN = ucn;
        }

        public int UCN
        {
            get { return this.ucn; }
            set { this.ucn = value; }
        }

        public string Comment { set; }
    }
}
