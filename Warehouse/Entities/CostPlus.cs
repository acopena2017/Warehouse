using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CostPlus
    {
        public CostPlus()
        {
            CostPlusMargin = new HashSet<CostPlusMargin>();
            CustomerXCostPlus = new HashSet<CustomerXCostPlus>();
        }

        public int CostPlusId { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int FromUserId { get; set; }
        public int EndUserId { get; set; }

        public virtual ICollection<CostPlusMargin> CostPlusMargin { get; set; }
        public virtual ICollection<CustomerXCostPlus> CustomerXCostPlus { get; set; }
    }
}
