using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ExternalTransfer
    {
        public ExternalTransfer()
        {
            ExternalTransferItem = new HashSet<ExternalTransferItem>();
        }

        public int ExternalTransferId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? RequestUserId { get; set; }
        public DateTime? PickedDate { get; set; }
        public int? PickUserId { get; set; }
        public DateTime? DriveDate { get; set; }
        public int? DriverUserId { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public int? ReceiveUserId { get; set; }
        public int? ReceiveBinId { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? CancelUserId { get; set; }
        public string Comment { get; set; }
        public bool IsForReserveOrder { get; set; }

        public virtual ICollection<ExternalTransferItem> ExternalTransferItem { get; set; }
        public virtual User CreateUser { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User DriverUser { get; set; }
        public virtual User PickUser { get; set; }
        public virtual User ReceiveUser { get; set; }
        public virtual User RequestUser { get; set; }
        public virtual ExternalTransferStatus Status { get; set; }
    }
}
