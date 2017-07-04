using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteStructure
    {
        public ShippingQuoteStructure()
        {
            ShippingQuote = new HashSet<ShippingQuote>();
            ShippingQuoteSchema = new HashSet<ShippingQuoteSchema>();
        }

        public int ShippingQuoteStructureId { get; set; }
        public string Description { get; set; }
        public int ShippingQuoteTypeId { get; set; }

        public virtual ICollection<ShippingQuote> ShippingQuote { get; set; }
        public virtual ICollection<ShippingQuoteSchema> ShippingQuoteSchema { get; set; }
        public virtual ShippingQuoteType ShippingQuoteType { get; set; }
    }
}
