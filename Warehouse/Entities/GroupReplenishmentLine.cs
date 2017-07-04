using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class GroupReplenishmentLine
    {
        public int GroupReplenishmentLineId { get; set; }
        public int GroupReplenishmentId { get; set; }
        public int ReplenishmentOrderLineId { get; set; }
        public string ReplenishmentType { get; set; }
    }
}
