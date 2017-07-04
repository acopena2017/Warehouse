using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingRate
    {
        public int ShippingRateId { get; set; }
        public int VendorId { get; set; }
        public string Name { get; set; }
        public int MinSkidCount { get; set; }
        public int MaxSkidCount { get; set; }
        public double ShippingRateTotal { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Expired { get; set; }
    }
}
