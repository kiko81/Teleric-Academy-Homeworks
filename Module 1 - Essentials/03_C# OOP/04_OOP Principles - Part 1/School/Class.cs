namespace School
{
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        public string uti; // UniqueTextIdentifier
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.Uti = uti;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string Uti { get; private set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public string Comment { set; }
    }
}
