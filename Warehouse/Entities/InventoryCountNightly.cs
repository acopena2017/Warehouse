using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class InventoryCountNightly
    {
        public int? StatusId { get; set; }
        public int NsInternalId { get; set; }
        public string Name { get; set; }
        public decimal? NsCount { get; set; }
    }
}
