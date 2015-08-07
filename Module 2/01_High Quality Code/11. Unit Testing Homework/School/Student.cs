namespace School
{
    using System;

    public class Student
    {
        private int id;
        private string name;

        public Student(string name,int id)
        {
            this.Id = id;
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("student name", "Student name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (10000 > value || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("ID not 5 digit number");
                }

                this.id = value;
            }
        }

        public void AttendCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.RemoveStudent(this);
        }
    }
}