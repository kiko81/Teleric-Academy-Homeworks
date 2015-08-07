namespace School.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolShouldNotThrowException()
        {
            var school = new School("Telerik");
        }

        [TestMethod]
        public void SchoolShouldReturnNameCorrectly()
        {
            var school = new School("Telerik");
            Assert.AreEqual("Telerik", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void SchoolShouldAddStudentCorrectly()
        {
            var school = new School("Telerik");
            var student = new Student("Pesho", 55555);
            school.AddStudent(student);
            Assert.AreSame(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNullStudentAdded()
        {
            var school = new School("Telerik");
            school.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenAddingExistingStudent()
        {
            var school = new School("Telerik ");
            var student = new Student("Pesho", 55555);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowExceptionWhenAddingStudentWithDuplicateId()
        {
            var school = new School("Telerik");
            var student = new Student("Pesho", 55555);
            var otherStudent = new Student("Gosho", 55555);
            school.AddStudent(student);
            school.AddStudent(otherStudent);
        }

        [TestMethod]
        public void SchoolShouldAddCourseCorrectly()
        {
            var school = new School("Telerik");
            var course = new Course("C#");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNullCourseAdded()
        {
            var school = new School("Telerik");
            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenExistingCourseAdded()
        {
            var school = new School("Telerik");
            var course = new Course("HTML");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void SchoolShouldRemoveStudentCorrectly()
        {
            var school = new School("Telerik");
            var student = new Student("Pesho", 55555);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.IsTrue(school.Students.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenRemovingNullStudent()
        {
            var school = new School("Telerik");
            school.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenRemovingNotExistingStudent()
        {
            var school = new School("Telerik");
            var student = new Student("Pesho", 55555);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void SchoolShouldRemoveCourseCorrectly()
        {
            var school = new School("Telerik");
            var course = new Course("CSS");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenRemovingNullCourse()
        {
            var school = new School("Telerik");
            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenRemovingNotExistingCourse()
        {
            var school = new School("Telerik");
            var course = new Course("HTML");
            school.RemoveCourse(course);
        }

        [TestMethod]
        public void CourseShoudNotThrowError()
        {
            var course = new Course("JavaScript");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWithNullName()
        {
            var course = new Course(null);
        }

        [TestMethod]
        public void CourseShoulReturnNameCorrectly()
        {
            var course = new Course("OOP");
            Assert.AreEqual("OOP", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWithEmptyName()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void CourseShouldAddStudentCorrectly()
        {
            var course = new Course("HQC");
            var student = new Student("Pesho", 55555);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenNullStudentAdded()
        {
            var course = new Course("DSA");
            course.AddStudent(null);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenExistingStudentAdded()
        {
            var course = new Course("HQC");
            Student student = new Student("Pesho", 55555);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenMoreThanPossibleStudentsAdded()
        {
            var course = new Course("HQC");

            for (int i = 0; i < 50; i++)
            {
                course.AddStudent(new Student(i.ToString() , 55555 + i));
            }
        }

        [TestMethod]
        public void CourseShouldRemoveStudentCorrectly()
        {
            var course = new Course("HTML");
            var student = new Student("Pesho", 22222);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenRemovingNullStudent()
        {
            var course = new Course("HQC");
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenRemovingUnexistingStudent()
        {
            var course = new Course("CSS");
            Student student = new Student("Pesho", 10000);
            course.RemoveStudent(student);
        }

        [TestMethod]
        public void StudentShouldNotThrowAnException()
        {
            var student = new Student("Pesho", 55555);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedName()
        {
            var student = new Student("Pesho", 55555);

            Assert.AreEqual("Pesho", student.Name);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedId()
        {
            var student = new Student("Pesho", 55555);

            Assert.AreEqual(55555, student.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowNullReferenceExceptionForNullName()
        {
            var student = new Student(null, 55555);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowNullReferenceExceptionForEmptyName()
        {
            var student = new Student(string.Empty, 55555);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowArgumentExceptionForInvalidId_Low()
        {
            var student = new Student("Pesho", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowArgumentExceptionForInvalidId_High()
        {
            var student = new Student("Pesho", 55555555);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenAttendingCourse()
        {
            var student = new Student("Pesho", 55555);
            var course = new Course("HTML");
            student.AttendCourse(course);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenLeavesCourse()
        {
            var student = new Student("Pesho", 55555);
            var course = new Course("CSS");
            student.AttendCourse(course);
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenAttendingNullCourse()
        {
            var student = new Student("Pesho", 55555);
            student.AttendCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenLeavingNullCourse()
        {
            var student = new Student("Pesho", 55555);
            Course course = null;
            student.LeaveCourse(course);
        }
    }
}
