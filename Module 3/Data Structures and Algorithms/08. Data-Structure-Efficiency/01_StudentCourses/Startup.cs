namespace StudentCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var studentCourses = new SortedDictionary<string, SortedDictionary<string, string>>();

            LoadStudentsFromFile(studentCourses);

            PrintStudents(studentCourses);
        }

        private static void PrintStudents(SortedDictionary<string, SortedDictionary<string, string>> studentCourses)
        {
            foreach (var course in studentCourses)
            {
                Console.Write($"{course.Key}: ");
                var people = course.Value.Select(person => $"{person.Value} {person.Key}")
                                   .ToList();

                Console.WriteLine(string.Join(", ", people));
            }
        }

        private static void LoadStudentsFromFile(SortedDictionary<string, SortedDictionary<string, string>> studentCourses)
        {
            var fileReader = new StreamReader(@"..\..\students.txt");
            using (fileReader)
            {
                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var lineContents = line?.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var course = lineContents[2].Trim();
                    var firstName = lineContents[0].Trim();
                    var lastName = lineContents[1].Trim();

                    if (!studentCourses.ContainsKey(course))
                    {
                        studentCourses.Add(course, new SortedDictionary<string, string>());
                    }

                    studentCourses[course].Add(lastName, firstName);
                }
            }
        }
    }
}
