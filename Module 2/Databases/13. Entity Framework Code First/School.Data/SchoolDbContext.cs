namespace School.Data
{
    using System.Data.Entity;

    using Model;

    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolDb")
        {
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }
    }
}
