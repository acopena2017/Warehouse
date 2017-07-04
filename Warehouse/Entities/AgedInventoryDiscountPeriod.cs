using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class AgedInventoryDiscountPeriod
    {
        public AgedInventoryDiscountPeriod()
        {
            ItemCategoryXAgedInventoryDiscountPeriod = new HashSet<ItemCategoryXAgedInventoryDiscountPeriod>();
        }

        public int AgedInventoryDiscountPeriodId { get; set; }
        public int PeriodMonths { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<ItemCategoryXAgedInventoryDiscountPeriod> ItemCategoryXAgedInventoryDiscountPeriod { get; set; }
    }
}
