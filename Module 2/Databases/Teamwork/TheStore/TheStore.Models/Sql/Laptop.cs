namespace TheStore.Models.Sql
{
    public class Laptop
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public int ClassId { get; set; }

        public virtual LaptopClass Class { get; set; }

        public decimal Price { get; set; }
    }
}
