namespace TheStore.MySql.Models
{
    using System;

    public class SalesReport
    {
        public int Id { get; set; }

        public string Town { get; set; }

        public DateTime Date { get; set; }

        public int LaptopId { get; set; }

        public int Quantity { get; set; }

        public decimal Sum { get; set; }
    }
}
