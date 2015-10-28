namespace ConcurentChanges
{
    using System.Linq;

    using NorthWindDBContext;

    public class ConcurentChanges
    {
        public static void Main()
        {
            using (var nw1 = new NorthwindEntities())
            {
                using (var nw2 = new NorthwindEntities())
                {
                    var rowFromFirst = nw1.Customers
                                      .First(c => c.ContactName.StartsWith("A"));
                    var rowFromSecond = nw2.Customers
                                          .First(c => c.ContactName.StartsWith("A"));

                    rowFromFirst.ContactName = "Pesho";
                    rowFromSecond.ContactName = "Gosho";

                    // Which was saved later will prevail

                    // nw1.SaveChanges();

                    // nw2.SaveChanges();
                }
            }
        }
    }
}