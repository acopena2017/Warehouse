using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingDeliveryDates
    {
        public int ShippingDeliveryDatesId { get; set; }
        public int OrderNumber { get; set; }
        public string ShipperName { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
    }
}
