using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemCategoryXApprovedVendor
    {
        public int ItemCategoryXApprovedVendorId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? VendorId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int VendorPercentage { get; set; }
    }
}
