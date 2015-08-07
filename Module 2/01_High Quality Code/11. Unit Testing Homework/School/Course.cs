namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;
        private ICollection<Student> students;
        private const int MaxStudentsInCourse = 30;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
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
                    throw new ArgumentNullException("course name", "Course name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student cannot be null.");
            }
            
            if (this.Students.Count >= MaxStudentsInCourse)
            {
                throw new InvalidOperationException("Student list is full.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already has joined the class.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("The student does not attend this class.");
            }
            
            this.students.Remove(student);
        }
    }
}