using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.Models
{
    internal class Batch
    {
        private int stock;

        public int BatchId { get; private set; }
        public Location BatchLocation { get; private set; }
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

        public Batch(int batchId, Location location, DateTime? batchExpiry = null)
        {
            BatchId = batchId;
            BatchLocation = location;
            ExpiryDate = batchExpiry;
        }

        public void UpdateStock(int amount)
        {
            Stock = amount;
        }

        public void MoveTo(Location dest)
        {
            BatchLocation = dest;
        }
    }
}
