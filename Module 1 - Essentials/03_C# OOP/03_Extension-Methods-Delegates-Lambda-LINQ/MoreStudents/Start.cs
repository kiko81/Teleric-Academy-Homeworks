using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroups
{
    class Start
    {
        static void Main()
        {
            #region students
            var students = new List<Student>()           
		    {
                new Student("Ivan", "Goshov", 1323006, "02475634", "ivan@bg.com", new List<int> {2, 3, 4, 6}, 3),
                new Student("Gosho", "Ivanov", 1322003, "35736743", "gosho@abv.bg", new List<int> {6, 6}, 2),
                new Student("Todor", "Asenski", 1311206, "02356743", "todor@com.bg", new List<int> {2, 2, 3}, 2),
                new Student("Greta", "Gecova", 2222213, "6579569", "greta@abv.bg", new List<int> {2, 6, 2}, 1),
                new Student("Petyr", "Petev", 2222065, "6579569", "petyr@bg.bg", new List<int> {5, 5, 6}, 1),
                new Student("Todor", "Ivanov", 2252214, "026579569", "t.odor@bg.bg", new List<int> { 2, 2, 2 }, 2)
           };
            #endregion

            Console.WriteLine("Students from 2nd group ordered by first name:");
            //First LINQ - lambda style commented on next line
            Console.WriteLine(string.Join(Environment.NewLine, OrderByFirstNameInGroup(students)));
            //Console.WriteLine(string.Join(Environment.NewLine, OrderByFirstNameInGroupLambda(students)));

            Console.WriteLine("\nStudents with mails in ABV:");
            Console.WriteLine(string.Join(Environment.NewLine, ExtractByMail(students)));

            Console.WriteLine("\nStudents with Sofia phone numbers:");
            Console.WriteLine(string.Join(Environment.NewLine, ExtractByPhone(students)));

            Console.WriteLine("\nStudents with excellent marks:");
            Console.WriteLine(string.Join(Environment.NewLine, ExtractExcelMarks(students)));

            Console.WriteLine("\nStudents with 2 poor marks:");
            Console.WriteLine(string.Join(Environment.NewLine, ExtractTwoPoorMarks(students)));

            Console.WriteLine("\nStudents enrolled in 2006:");
            Console.WriteLine(string.Join(Environment.NewLine, ExtractEnrolledIn06(students)));

            //problems 18 and 19 - First LINQ - next line commented lambda style
            Console.WriteLine("\nStudents ordered by group:");
            Console.WriteLine(string.Join(Environment.NewLine, OrderByGroupLINQ(students)));
            //Console.WriteLine(string.Join(Environment.NewLine, OrderByGroupLambda(students)));     
        }

        private static IOrderedEnumerable<Student> OrderByGroupLambda(List<Student> students)
        {
            var result = students
                .OrderBy(x => x.GroupNumber);
            return result;
        }

        private static IOrderedEnumerable<Student> OrderByGroupLINQ(List<Student> students)
        {
            var result =
                from student in students
                orderby student.GroupNumber
                select student;
            return result;
        }

        private static List<string> ExtractEnrolledIn06(List<Student> students)
        {
            var enroledIn06 = students
                .Where(x => x.FN.ToString().Substring(5, 2) == "06")
                .Select(x => new { FullName = x.FirstName + " " + x.LastName, Marks = string.Join(", ", x.Marks) });

            var result = new List<string>();

            foreach (var student in enroledIn06)
            {
                result.Add(String.Format("{0} - marks: {1}", student.FullName, student.Marks));
            }
            return result;
        }

        private static List<string> ExtractTwoPoorMarks(List<Student> students)
        {
            var twoPoorMarks = students
                .Where(x => x.Marks.FindAll(y => y == 2).Count == 2)
                .Select(x => new { FullName = string.Format("{0} {1}", x.FirstName, x.LastName), Marks = string.Join(", ", x.Marks) });

            var result = new List<string>();

            foreach (var student in twoPoorMarks)
            {
                result.Add(String.Format("{0} - marks: {1}", student.FullName, student.Marks));
            }
            return result;
        }

        private static List<string> ExtractExcelMarks(List<Student> students)
        {
            var excelMarks =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = String.Format("{0} {1}", student.FirstName, student.LastName), Marks = student.Marks };

            var result = new List<string>();

            foreach (var student in excelMarks)
            {
                result.Add(String.Format("{0} - marks: {1}", student.FullName, String.Join(", ", student.Marks)));
            }
            return result;
        }

        private static IEnumerable<Student> ExtractByPhone(List<Student> students)
        {
            var result =
                from student in students
                where student.PhoneNr.Substring(0, 2) == "02"
                select student;
            return result;
        }

        private static IEnumerable<Student> ExtractByMail(List<Student> students)
        {
            var result =
                from student in students
                where student.Email.Substring(student.Email.Length - 6) == "abv.bg"
                select student;
            return result;
        }

        private static IEnumerable<Student> OrderByFirstNameInGroupLambda(List<Student> students)
        {
            var result = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();
            return result;
        }

        private static IEnumerable<Student> OrderByFirstNameInGroup(List<Student> students)
        {
            var result =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            return result;
        }
    }
}
