using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class SalesChannel
    {
        public SalesChannel()
        {
            InStockPickingHistory2 = new HashSet<InStockPickingHistory2>();
        }

        public int SalesChannelId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InStockPickingHistory2> InStockPickingHistory2 { get; set; }
    }
}
