namespace LargeCollectionSearch
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return this.Name + " -> " + this.Price;
        }
    }
}