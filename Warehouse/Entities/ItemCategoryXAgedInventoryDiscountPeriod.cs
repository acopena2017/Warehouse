using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemCategoryXAgedInventoryDiscountPeriod
    {
        public int ItemCategoryXAgedInventoryDiscountPeriodId { get; set; }
        public int ItemCategoryId { get; set; }
        public int AgedInventoryDiscountPeriodId { get; set; }
        public double Discount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual AgedInventoryDiscountPeriod AgedInventoryDiscountPeriod { get; set; }
        public virtual ItemCategory ItemCategory { get; set; }
    }
}
