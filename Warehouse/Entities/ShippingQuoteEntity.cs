using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteEntity
    {
        public int ShippingQuoteEntityId { get; set; }
        public double Value { get; set; }
        public int ShippingQuoteId { get; set; }
        public int ShippingQuoteEntityTypeId { get; set; }

        public virtual ShippingQuoteEntityType ShippingQuoteEntityType { get; set; }
        public virtual ShippingQuote ShippingQuote { get; set; }
    }
}
