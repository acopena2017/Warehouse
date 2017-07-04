using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class InStockPickingHistoryAll
    {
        public int InStockPickingHistoryId { get; set; }
        public int? SourceInStockPickingHistoryId { get; set; }
        public int ItemId { get; set; }
        public DateTime StockDate { get; set; }
        public int PickTotal { get; set; }
    }
}
