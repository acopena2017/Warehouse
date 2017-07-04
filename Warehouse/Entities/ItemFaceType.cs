using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemFaceType
    {
        public ItemFaceType()
        {
            ItemXAsn = new HashSet<ItemXAsn>();
        }

        public int ItemFaceTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemXAsn> ItemXAsn { get; set; }
    }
}
