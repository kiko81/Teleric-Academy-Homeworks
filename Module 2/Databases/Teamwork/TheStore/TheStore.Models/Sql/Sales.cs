namespace TheStore.Models.Sql
{
    using System;

    public class Sales
    {
        public int Id { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public DateTime Date { get; set; }

        public int LaptopId { get; set; }

        public virtual Laptop Laptop { get; set; }

        public int Quantity { get; set; }
    }
}
