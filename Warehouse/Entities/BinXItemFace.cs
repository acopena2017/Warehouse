using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class BinXItemFace
    {
        public int BinXItemFaceId { get; set; }
        public int BinId { get; set; }
        public int ItemId { get; set; }
        public int ItemXAsnId { get; set; }
        public bool ManualOverride { get; set; }
        public bool IsPalletBin { get; set; }
        public int StackAlignment { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ClearDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
