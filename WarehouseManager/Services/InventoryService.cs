using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManager.Repositories;

namespace WarehouseManager.Services
{
    internal class InventoryService
    {
        private readonly ProductRepository productRepo;
        private readonly BatchRepository batchRepo;
        private readonly LocationRepository locationRepo;
    }
}
