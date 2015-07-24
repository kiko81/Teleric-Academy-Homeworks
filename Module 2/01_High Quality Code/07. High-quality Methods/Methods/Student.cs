namespace Methods
{
    using System;

    public class Student
    {
        private DateTime dateOfBirth;
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
            this.DateOfBirth = new DateTime();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("invalid first name");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("invalid last name");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo { get; set; }

        public DateTime DateOfBirth
        {
            get
            {
                return DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            }
            set
            {
                DateTime date;

                if (DateTime.TryParse(this.OtherInfo.Substring(this.OtherInfo.Length - 10), out date))
                {
                    this.dateOfBirth = date;
                }
                else
                {
                    throw new ArgumentException("invalid date");
                }

            }
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.dateOfBirth;
            DateTime secondDate = other.dateOfBirth;

            return firstDate > secondDate;
        }
    }
}
