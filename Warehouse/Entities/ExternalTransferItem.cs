using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ExternalTransferItem
    {
        public ExternalTransferItem()
        {
            ExternalTransferSource = new HashSet<ExternalTransferSource>();
        }

        public int ExternalTransferItemId { get; set; }
        public int ExternalTransferId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int? ReserveReference { get; set; }

        public virtual ICollection<ExternalTransferSource> ExternalTransferSource { get; set; }
        public virtual ExternalTransfer ExternalTransfer { get; set; }
        public virtual Item Item { get; set; }
    }
}
