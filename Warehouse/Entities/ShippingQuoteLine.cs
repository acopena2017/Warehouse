using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteLine
    {
        public int ShippingQuoteLineId { get; set; }
        public int ShippingQuoteId { get; set; }

        public virtual ShippingQuote ShippingQuote { get; set; }
    }
}
