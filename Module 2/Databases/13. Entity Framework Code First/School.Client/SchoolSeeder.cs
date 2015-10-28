namespace School.Client
{
    using System;
    using System.Linq;

    using Data;

    using Model;

    public class SchoolSeeder
    {
        private SchoolDbContext db = new SchoolDbContext();
        private RandomGenerator randomGenerator;

        public SchoolSeeder(RandomGenerator rand)
        {
            this.randomGenerator = rand;
        }

        public void SeedStudents(int studentsCount)
        {
            for (int i = 0; i < studentsCount; i++)
            {
                var student = new Student()
                {
                    Name = this.randomGenerator.GetRandomString()
                };

                this.db.Students.Add(student);

                if (this.db.ChangeTracker.Entries<Student>().Count() > 1000)
                {
                    this.ResetDb();
                }
            }

            this.ResetDb();
        }

        public void SeedCourses(int coursesCount)
        {
            for (int i = 0; i < coursesCount; i++)
            {
                var course = new Course()
                {
                    Description = this.randomGenerator.GetRandomString(),
                    Name = this.randomGenerator.GetRandomString()
                };

                this.db.Courses.Add(course);

                if (this.db.ChangeTracker.Entries<Course>().Count() > 1000)
                {
                    this.ResetDb();
                }
            }

            this.ResetDb();
        }

        public void SeedHomeworks(int homeworksCount)
        {
            for (int i = 0; i < homeworksCount; i++)
            {
                int year = this.randomGenerator.GetRandomInteger(1997, 2015);
                int month = this.randomGenerator.GetRandomInteger(1, 12);
                int day = this.randomGenerator.GetRandomInteger(1, 28);

                var hw = new Homework()
                {
                    Content = this.randomGenerator.GetRandomString(),
                    TimeSent = new DateTime(year, month, day)
                };

                this.db.Homeworks.Add(hw);

                if (this.db.ChangeTracker.Entries<Homework>().Count() > 1000)
                {
                    this.ResetDb();
                }
            }

            this.ResetDb();
        }

        public void SeedStudentCourses()
        {
            int courseCount = this.db.Courses.Count();
            if (courseCount <= 2)
            {
                return;
            }

            var studentCount = this.db.Students.Count();
            for (int i = 1; i <= studentCount; i++)
            {
                var student = this.db.Students.First(c => c.Id == i);

                var coursesCount = this.randomGenerator.GetRandomInteger(1, 5);
                for (int j = 0; j < coursesCount; j++)
                {
                    var randCourseId = this.randomGenerator.GetRandomInteger(1, courseCount);
                    var course = this.db.Courses.First(c => c.Id == randCourseId);

                    student.Courses.Add(course);
                }
            }

            this.db.SaveChanges();
        }

        public void SeedStudentHomeworks()
        {
            var studentCount = this.db.Students.Count();
            for (int i = 1; i <= studentCount; i++)
            {
                var randomHwId = this.randomGenerator.GetRandomInteger(1, this.db.Homeworks.Count());
                var hw = this.db.Homeworks.First(c => c.Id == randomHwId);

                var student = this.db.Students.First(c => c.Id == i);
                student.Homework.Add(hw);

                if (this.db.ChangeTracker.Entries().Count() > 1000)
                {
                    this.ResetDb();
                }
            }

            this.ResetDb();
        }

        private void ResetDb()
        {
            this.db.SaveChanges();
            this.db = new SchoolDbContext();
        }
    }
}
