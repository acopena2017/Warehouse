using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemPalletQuantity
    {
        public int ItemPalletQuantityId { get; set; }
        public int ItemId { get; set; }
        public int PalletQuantity { get; set; }
        public bool ItemDefault { get; set; }
    }
}
