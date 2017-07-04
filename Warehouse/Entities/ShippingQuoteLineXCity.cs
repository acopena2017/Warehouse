using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingQuoteLineXCity
    {
        public int ShippingQuoteLineXCityId { get; set; }
        public int ShippingQuoteLineId { get; set; }
        public int CityId { get; set; }
    }
}
