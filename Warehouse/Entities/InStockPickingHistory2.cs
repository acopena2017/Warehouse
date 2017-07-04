using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class InStockPickingHistory2
    {
        public int InStockPickingHistoryId { get; set; }
        public int ItemId { get; set; }
        public DateTime StockDate { get; set; }
        public int PickTotal { get; set; }
        public int SalesChannelId { get; set; }

        public virtual Item Item { get; set; }
        public virtual SalesChannel SalesChannel { get; set; }
    }
}
