using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXEdiLocationCode
    {
        public int CustomerXEdiLocationCodeId { get; set; }
        public int? CustomerId { get; set; }
        public int? EdiProviderId { get; set; }
        public string LocationCode { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual EdiProvider EdiProvider { get; set; }
    }
}
