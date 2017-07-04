using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteSchema
    {
        public int ShippingQuoteSchemaId { get; set; }
        public int Occurrences { get; set; }
        public string OccurenceValues { get; set; }
        public bool IsColumn { get; set; }
        public int? ColumnIndex { get; set; }
        public int ShippingQuoteStructureId { get; set; }
        public int ShippingQuoteEntityTypeId { get; set; }

        public virtual ShippingQuoteEntityType ShippingQuoteEntityType { get; set; }
        public virtual ShippingQuoteStructure ShippingQuoteStructure { get; set; }
    }
}
