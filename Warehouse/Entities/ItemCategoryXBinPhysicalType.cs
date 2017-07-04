using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemCategoryXBinPhysicalType
    {
        public int ItemCategoryXBinPhysicalTypeId { get; set; }
        public int ItemCategoryId { get; set; }
        public int BinPhysicalTypeId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
