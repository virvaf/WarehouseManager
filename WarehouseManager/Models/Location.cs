using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.Models
{
    internal class Location
    {
        public int LocationId { get; private set; }
        public string Code { get; private set; }

        public Location(int locationId, string code)
        {
            LocationId = locationId;
            Code = code;
        }
    }
}
