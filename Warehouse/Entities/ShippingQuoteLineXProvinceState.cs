using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteLineXProvinceState
    {
        public int ShippingQuoteLineXProvinceStateId { get; set; }
        public int ShippingQuoteLineId { get; set; }
        public int ProvinceStateId { get; set; }
    }
}
