using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class InventoryCountNightlyStatus
    {
        public int StatusId { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
    }
}
