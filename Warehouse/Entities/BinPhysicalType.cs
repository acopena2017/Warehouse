using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class BinPhysicalType
    {
        public int BinPhysicalTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool MultipleFaces { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
