using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class VendorXAddress
    {
        public int VendorXAddressId { get; set; }
        public int VendorId { get; set; }
        public int AddressId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
