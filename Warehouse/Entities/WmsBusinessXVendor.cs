using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class WmsBusinessXVendor
    {
        public int WmsBusinessXVendorId { get; set; }
        public int WmsBusinessId { get; set; }
        public int VendorId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
