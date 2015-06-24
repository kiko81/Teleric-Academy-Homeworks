namespace StudentClass
{
    using System;
    using System.Text;

    class Student : ICloneable, IComparable
    {
        private readonly Specialty specialty;
        private readonly University university;
        private readonly Facylty faculty;
        private string firstName;
        private char middleName;
        private string lastName;
        private long ssn;
        private string adress;
        private long phoneNumber;
        private string email;
        private string course;

        public Student(string firstName, char middleName, string lastName, long ssn, string adress, long phoneNumber, string email, string course, Specialty specialty, University university, Facylty faculty)
        {
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
        }

        public Facylty Faculty { get; set; }

        public University University { get; set; }

        public Specialty Specialty { get; set; }

        public string Course { get; set; }

        public string Email { get; private set; }

        public long PhoneNumber { get; set; }

        public string Adress { get; set; }

        public long Ssn { get; private set; }

        public string LastName { get; private set; }

        public char MiddleName { get; private set; }

        public string FirstName { get; private set; }


        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (this.Ssn == student.Ssn)
            {
                return true;
            }
            
            return false;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("Name: "+ this.FirstName + this.MiddleName + '.' + this.LastName);
            result.AppendLine("SSN: " + this.Ssn);
            result.AppendLine("University: " + this.University);
            result.AppendLine("Faculty: " + this.Faculty);
            result.AppendLine("Specialty: " + this.Specialty);
            result.AppendLine("Adress: " + this.Adress);
            result.AppendLine("Phone Number: " + this.PhoneNumber);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Course: " + this.Course);

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Ssn.GetHashCode() ^ this.PhoneNumber.GetHashCode();
        }

       public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return (firstStudent.Equals(secondStudent));
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent.Equals(secondStudent));
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Adress, this.PhoneNumber, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(object obj)
        {
            var other = obj as Student;

            var nameOfStudent = this.FirstName + this.MiddleName + this.LastName;
            var nameOfOther = other.FirstName + other.MiddleName + other.LastName;

            if (nameOfStudent == nameOfOther)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }

            return nameOfStudent.CompareTo(nameOfOther);
        }
    }
}
