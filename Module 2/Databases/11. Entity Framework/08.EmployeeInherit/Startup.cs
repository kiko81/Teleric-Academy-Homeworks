namespace EmployeeInherit
{
    using System;
    using System.Linq;

    using NorthWindDBContext;

    public class Startup
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                foreach (var employee in db.Employees.Include("Territories"))
                {
                    var correspondingTerritoriesAsString = string.Join(", ", employee.Territories
                        .Select(c => c.TerritoryDescription.Trim()));
                    Console.WriteLine("{0} -> Territorries: {1}", employee.FirstName, correspondingTerritoriesAsString);
                }
            }
        }
    }
}
