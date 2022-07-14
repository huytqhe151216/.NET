using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            return obj is Cart cart &&
                   EqualityComparer<Product>.Default.Equals(Product, cart.Product);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Product);
        }
    }
}
