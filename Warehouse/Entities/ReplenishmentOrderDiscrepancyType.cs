using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ReplenishmentOrderDiscrepancyType
    {
        public int ReplenishmentOrderDiscrepancyTypeId { get; set; }
        public string DiscrepancyName { get; set; }
        public string DiscrepancyDescription { get; set; }
    }
}
