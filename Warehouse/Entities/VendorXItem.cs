using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class VendorXItem
    {
        public int VendorXItemId { get; set; }
        public int? VendorId { get; set; }
        public int? ItemId { get; set; }
        public decimal? Cost { get; set; }
        public int Qt { get; set; }
        public string BuyingUnit { get; set; }
    }
}
