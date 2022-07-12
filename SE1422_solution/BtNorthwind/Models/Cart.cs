namespace BtNorthwind.Models
{
    public class Cart
    {
        public Product Product { get; set; }
        public int quantity { get; set; }

        public Cart(Product product, int quantity)
        {
            Product = product;
            this.quantity = quantity;
        }
        public decimal? ToPrice()
        {
            return (decimal)quantity*Product.UnitPrice;
        }
    }
}
