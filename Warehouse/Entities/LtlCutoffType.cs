using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class LtlCutoffType
    {
        public LtlCutoffType()
        {
            ShippingQuote = new HashSet<ShippingQuote>();
        }

        public int LtlCutoffTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ShippingQuote> ShippingQuote { get; set; }
    }
}
