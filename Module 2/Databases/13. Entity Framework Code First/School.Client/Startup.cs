namespace School.Client
{
    public class Startup
    {
        public static void Main()
        {
            var rand = new RandomGenerator();
            var seeder = new SchoolSeeder(rand);

            seeder.SeedStudents(50);
            seeder.SeedCourses(50);
            seeder.SeedHomeworks(50);

            seeder.SeedStudentCourses();
            seeder.SeedStudentHomeworks();
        }
    }
}
