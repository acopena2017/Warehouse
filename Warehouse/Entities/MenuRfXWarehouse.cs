using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class MenuRfXWarehouse
    {
        public int MenuRfXWarehouseId { get; set; }
        public int? MenuRfId { get; set; }
        public int? WarehouseId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
