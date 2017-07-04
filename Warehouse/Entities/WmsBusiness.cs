using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class WmsBusiness
    {
        public int WmsBusinessId { get; set; }
        public string Name { get; set; }
        public string OrdersEmail { get; set; }
        public string Description { get; set; }
        public bool? Expired { get; set; }
        public bool? GenerateIwto { get; set; }
        public string RfDeviceStartIp { get; set; }
        public string RfDeviceEndIp { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool? HasInventory { get; set; }
        public bool? GenerateOrderLevels { get; set; }
        public string CustomerTypes { get; set; }
        public int? ConnectedToWarehouse { get; set; }
    }
}
