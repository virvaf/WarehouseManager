using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager
{
    internal class Product
    {
        private int stock;
        private decimal price;

        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public Location Location { get; private set; }
        public string? Description { get; private set; }
        public DateTime? ExpiryDate { get; private set; }

        public int Stock 
        {
            get { return stock; } 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stock count cannot be negative");
                }
                stock = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                price = value;
            }
        }

        public Product(int productId, string productName, Location productLocation, int productStock, decimal productPrice, string? productDescription = null, DateTime? expiryDate = null)
        {
            ProductId = productId;
            Name = productName;
            Location = productLocation;
            Stock = productStock;
            Price = productPrice;
            Description = productDescription;
            ExpiryDate = expiryDate;
        }
    }
}
