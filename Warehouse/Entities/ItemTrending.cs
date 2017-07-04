using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemTrending
    {
        public int ItemTrendingId { get; set; }
        public int? TrendMonth { get; set; }
        public int? TrendYear { get; set; }
        public decimal? TrendMultiplier { get; set; }
    }
}
