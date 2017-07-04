using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ExternalTransferStatus
    {
        public ExternalTransferStatus()
        {
            ExternalTransfer = new HashSet<ExternalTransfer>();
        }

        public int ExternalTransferStatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ExternalTransfer> ExternalTransfer { get; set; }
    }
}
