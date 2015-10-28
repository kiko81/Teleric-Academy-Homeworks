namespace FindSpecificSales
{
    using System;
    using System.Linq;

    using NorthWindDBContext;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter region of the sale (e.g. sp, bc, null works too but a lot of them will come) ");

            var region = Console.ReadLine().ToUpper();

            if (string.IsNullOrWhiteSpace(region))
            {
                region = null;
            }

            Console.Write("Enter start date (years ago, will search until now): ");
            int startDateInput;

            int.TryParse(Console.ReadLine(), out startDateInput);

            var startDate = DateTime.Now.AddYears(-startDateInput);
            var endDate = DateTime.Now;

            using (var db = new NorthwindEntities())
            {
                var orders = db.Orders
                  .Where(o => o.ShipRegion == region && 
                    o.OrderDate >= startDate &&
                    o.OrderDate <= endDate)
                  .ToList();

                if (orders.Any())
                {
                    Console.WriteLine("OrderID " +
                    string.Join(Environment.NewLine + "OrderID ", orders.Select(o => o.OrderID)));
                    Console.WriteLine("Number of orders: " + orders.Count);
                }
                else
                {
                    Console.WriteLine("No such sales");
                }
            }
        }
    }
}
