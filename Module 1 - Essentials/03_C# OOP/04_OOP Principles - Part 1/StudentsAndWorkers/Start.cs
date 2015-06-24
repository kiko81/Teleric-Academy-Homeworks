namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student("Ivan", "Dobrev", 3),
                new Student("Gosho", "Toshev", 4),
                new Student("Todor ", "Toshev", 3),
                new Student("6o6o", "6o6ev", 2),
                new Student("Alf", "Taner", 6),
                new Student("Ivan", "Ivanov", 5),
                new Student("Pesho", "U4ev", 2),
                new Student("Ivo", "Ivov", 6),
                new Student("Kolyo", "Kokalov", 6),
                new Student("Andon", "Paskov", 5)

            };
            Console.WriteLine("Students surted by grade");
            foreach (var student in students.OrderBy(x => x.Grade))
            {
                Console.WriteLine("{0} {1}: grade:{2} ",  student.FirstName, student.LastName, student.Grade);
            }

            var workers = new List<Worker>
            {
                new Worker("Pyrvan","Vtorev", 2000.45m, 8),
                new Worker("Vtoran","Tretev", 390, 8),
                new Worker("Tretan","Pyrvanov", 15745m, 8),
                new Worker("Pyrvan","Ivov", 4534535, 13),
                new Worker("Ivan","Vtorev", (decimal)Math.PI * 1000, 24),
                new Worker("Dragan","Kolev", 0, 4),
                new Worker("Stefan","Petev", 123456.789m, 8),
                new Worker("Petkan","Nedelev", 222, 3),
                new Worker("Pantaley","Razvigorov", 1425.67m,9),
                new Worker("Nikodin","Pantaleev", 1000, 8)
            };

            Console.WriteLine("\nWorkers sorted by hourly rate");
            foreach (var worker in workers.OrderByDescending(x => x.MoneyPerHour()))
            {
                Console.WriteLine("{0} {1}: Hourly rate:{2:f2} ", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine("\nBoth lists sorted by first and last name");
            foreach (var human in students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
