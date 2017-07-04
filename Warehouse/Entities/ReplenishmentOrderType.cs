using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ReplenishmentOrderType
    {
        public int ReplenishmentOrderTypeId { get; set; }
        public string ReplenishmentOrderTypeName { get; set; }
        public int? ReplenishmentTransferTypeId { get; set; }
    }
}
