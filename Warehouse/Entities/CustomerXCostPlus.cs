using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXCostPlus
    {
        public int CustomerXCostPlusId { get; set; }
        public int CostPlusId { get; set; }
        public int CustomerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int FromUserId { get; set; }
        public int EndUserId { get; set; }

        public virtual CostPlus CostPlus { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
