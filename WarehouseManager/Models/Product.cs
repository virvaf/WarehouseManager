using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.Models
{
    internal class Product
    {
        private decimal price;

        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }


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

        public Product(int productId, string productName, decimal productPrice, string? productDescription = null)
        {
            ProductId = productId;
            Name = productName;
            Price = productPrice;
            Description = productDescription;
        }

        public void UpdatePrice(decimal value)
        {
            Price = value;
        }
    }
}
