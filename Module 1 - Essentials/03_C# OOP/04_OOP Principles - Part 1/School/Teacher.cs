namespace School
{
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> courses)
            : base(name)
        {
            this.Disciplines = courses;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

        public string Comment { set; }
    }
}
