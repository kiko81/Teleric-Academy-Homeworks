namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Start
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Ivan", "Goshov", 26));
            students.Add(new Student("Gosho", "Ivanov", 19));
            students.Add(new Student("Todor", "Asenski", 33));
            students.Add(new Student("Greta", "Gecova", 19));
            students.Add(new Student("Petyr", "Petev", 29));
            students.Add(new Student("Todor", "Yanev", 20));

            Console.WriteLine("first name before last:");
            foreach (var st in FirstNameBeforeLast(students))
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine("\n18>=age<=24:");
            foreach (var st in Age18To24(students))
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine("\nordered by first and last name:");
            foreach (var st in LambdaOrderByNames(students))
            //foreach (var st in LINQorderByNames(students))
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

        }

        private static IEnumerable<Student> FirstNameBeforeLast(List<Student> students)
        {
            var result =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return result;
        }

        private static IEnumerable<Student> Age18To24(List<Student> students)
        {
            var result =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;
            return result;
        }

        private static IEnumerable<Student> LambdaOrderByNames(List<Student> students)
        {
            var result = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToList();
                
            return result;
        }

        private static IEnumerable<Student> LINQorderByNames(List<Student> students)
        {
            var result =
                from student in students
                orderby student.FirstName descending
                orderby student.LastName descending
                select student;

            return result;
        }
    }
}
