using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ExternalTransferSource
    {
        public int ExternalTransferSourceId { get; set; }
        public int ExternalTransferItemId { get; set; }
        public int BinId { get; set; }
        public int Quantity { get; set; }
        public DateTime? PickedDate { get; set; }
        public int PickedQuantity { get; set; }
        public int ReasonId { get; set; }

        public virtual ExternalTransferItem ExternalTransferItem { get; set; }
    }
}
