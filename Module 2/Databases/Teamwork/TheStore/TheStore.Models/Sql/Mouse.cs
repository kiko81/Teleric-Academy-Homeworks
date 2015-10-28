namespace TheStore.Models.Sql
{
    public class Mouse
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public int Dpi { get; set; }

        public bool IsWireless { get; set; }

        public decimal Price { get; set; }
    }
}
