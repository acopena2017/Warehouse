using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CostPlusMargin
    {
        public int CostPlusMarginId { get; set; }
        public int CostPlusId { get; set; }
        public decimal Margin { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int FromUserId { get; set; }
        public int EndUserId { get; set; }

        public virtual CostPlus CostPlus { get; set; }
    }
}
