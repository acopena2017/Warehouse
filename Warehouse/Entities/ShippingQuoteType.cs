using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteType
    {
        public ShippingQuoteType()
        {
            ShippingQuote = new HashSet<ShippingQuote>();
            ShippingQuoteStructure = new HashSet<ShippingQuoteStructure>();
        }

        public int ShippingQuoteTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ShippingQuote> ShippingQuote { get; set; }
        public virtual ICollection<ShippingQuoteStructure> ShippingQuoteStructure { get; set; }
    }
}
