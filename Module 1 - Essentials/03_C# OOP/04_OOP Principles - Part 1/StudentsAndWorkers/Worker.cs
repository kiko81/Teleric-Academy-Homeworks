namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal salary, int hours) : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return WeekSalary / WorkHoursPerDay / 5;
        }
    }
}
