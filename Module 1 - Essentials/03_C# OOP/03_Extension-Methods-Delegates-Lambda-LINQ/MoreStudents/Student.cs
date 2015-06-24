namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string phoneNr;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int fn,
            string phoneNr, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.PhoneNr = phoneNr;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }
        

        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }


        public string PhoneNr
        {
            get { return this.phoneNr; }
            set { this.phoneNr = value; }
        }
        

        public int FN
        {
            get { return this.fn; }
            set { this.fn = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " - FN:" + this.FN + " phone:" + this.PhoneNr + " " + this.Email + " group:" + this.GroupNumber;
        }
    }
}
