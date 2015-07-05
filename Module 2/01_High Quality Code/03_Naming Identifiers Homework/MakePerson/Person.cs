namespace MakePerson
{
    public class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public void MakePerson(int age)
        {
            var newPerson = new Person();

            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "Brute";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Chick";
                newPerson.Gender = Gender.Female;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} ({1}, {2})", this.Name, this.Gender, this.Age);
        }
    }
}

