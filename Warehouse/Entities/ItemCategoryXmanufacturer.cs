using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemCategoryXmanufacturer
    {
        public int ItemCategoryId { get; set; }
        public string ManufacturerName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
