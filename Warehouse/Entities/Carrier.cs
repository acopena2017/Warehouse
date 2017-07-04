using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Carrier
    {
        public int CarrierId { get; set; }
        public int? VendorId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Skids { get; set; }
        public decimal? Cost { get; set; }
    }
}
