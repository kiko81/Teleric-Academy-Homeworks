namespace TheStore.Excel
{
    public class SalesInfo
    {
        public SalesInfo(int productId, decimal productPrice, int quantity)
        {
            this.ProductId = productId;
            this.Price = productPrice;
            this.Quantity = quantity;
        }

        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Sum
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }
    }
}
