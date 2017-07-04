using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class PackagingType
    {
        public int PackagingTypeId { get; set; }
        public string Name { get; set; }
        public string PriceImportName { get; set; }
        public string PriceListName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
