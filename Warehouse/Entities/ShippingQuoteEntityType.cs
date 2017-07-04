using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteEntityType
    {
        public ShippingQuoteEntityType()
        {
            ShippingQuoteEntity = new HashSet<ShippingQuoteEntity>();
            ShippingQuoteSchema = new HashSet<ShippingQuoteSchema>();
        }

        public int ShippingQuoteEntityTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ShippingQuoteEntityValueTypeId { get; set; }

        public virtual ICollection<ShippingQuoteEntity> ShippingQuoteEntity { get; set; }
        public virtual ICollection<ShippingQuoteSchema> ShippingQuoteSchema { get; set; }
    }
}
