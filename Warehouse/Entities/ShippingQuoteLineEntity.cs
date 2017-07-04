using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteLineEntity
    {
        public int ShippingQuoteLineEntityId { get; set; }
        public int ShippingQuoteLineId { get; set; }
        public int ShippingQuoteEntityTypeId { get; set; }
        public int OccurrenceValue { get; set; }
        public double LineEntityValue { get; set; }
    }
}
