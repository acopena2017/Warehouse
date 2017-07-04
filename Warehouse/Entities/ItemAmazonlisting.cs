using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemAmazonlisting
    {
        public string Sku { get; set; }
        public string Asin { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
