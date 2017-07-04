using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class UspsorderParts
    {
        public int OrderPartId { get; set; }
        public string ItemName { get; set; }
        public int? OrderId { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
    }
}
