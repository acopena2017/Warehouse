using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class VendorXManufacturer
    {
        public int VendorId { get; set; }
        public int ManufacturerId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
    }
}
