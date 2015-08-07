namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<Course> courses;
        private ICollection<Student> students;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentNullException("school name", "School name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
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

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student has been already added.");
            }

            if (student.GetType() != typeof(Student))
            {
                throw new ArgumentException("You cannot add non student objects to students");
            }

            if (this.students.Any(st => st.Id == student.Id))
            {
                throw new ArgumentException("There is already a student with the same ID.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Removing student requires student object as argument");
            }

            if (student.GetType() != typeof(Student))
            {
                throw new ArgumentException("You cannot remove non student objects from students");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("There is no such student.");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Adding course requires course object as argument");
            }

            if (course.GetType() != typeof (Course))
            {
                throw new ArgumentException("You cannot add non course objects to courses");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("Such course already exists.");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("There is no such course.");
            }
            
            this.courses.Remove(course);
        }
    }
}