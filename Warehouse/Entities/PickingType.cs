using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class PickingType
    {
        public int PickingTypeId { get; set; }
        public string PickingTypeName { get; set; }
        public string PickingTypeDescription { get; set; }
        public int MaxItemsPerBin { get; set; }
        public bool AllowHeavy { get; set; }
        public bool AllowPick { get; set; }
        public bool AllowPalletPick { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
    }
}
