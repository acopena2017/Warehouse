using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemKit
    {
        public int KitItemId { get; set; }
        public int AtomicItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastUpdated { get; set; }

        public virtual Item AtomicItem { get; set; }
        public virtual Item KitItem { get; set; }
    }
}
