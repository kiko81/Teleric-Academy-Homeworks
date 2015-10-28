namespace FindOrders97
{
    using System;
    using System.Linq;

    using NorthWindDBContext;

    public static class Startup
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers
                                  .Where(c => c.Orders.Any(o => o.OrderDate.Value.Year == 1997 &&
                                  o.ShipCountry == "Canada"))
                                  .Select(c => c.ContactName)
                                  .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, customers));
            }
        }
    }
}
