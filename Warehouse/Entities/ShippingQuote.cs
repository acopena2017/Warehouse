using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuote
    {
        public ShippingQuote()
        {
            ShippingQuoteEntity = new HashSet<ShippingQuoteEntity>();
            ShippingQuoteLine = new HashSet<ShippingQuoteLine>();
        }

        public int ShippingQuoteId { get; set; }
        public int VendorId { get; set; }
        public string Name { get; set; }
        public DateTime Expiration { get; set; }
        public int ShippingQuoteTypeId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? Ltlcdn { get; set; }
        public double? Ftlcdn { get; set; }
        public double? Ltlus { get; set; }
        public double? Ftlus { get; set; }
        public double LtlCutoff { get; set; }
        public int LtlCutoffTypeId { get; set; }
        public int? ShippingQuoteStructureId { get; set; }
        public int? MaxSkidWeight { get; set; }

        public virtual ICollection<ShippingQuoteEntity> ShippingQuoteEntity { get; set; }
        public virtual ICollection<ShippingQuoteLine> ShippingQuoteLine { get; set; }
        public virtual LtlCutoffType LtlCutoffType { get; set; }
        public virtual ShippingQuoteStructure ShippingQuoteStructure { get; set; }
        public virtual ShippingQuoteType ShippingQuoteType { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
