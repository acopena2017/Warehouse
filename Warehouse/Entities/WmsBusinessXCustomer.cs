using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class WmsBusinessXCustomer
    {
        public int WmsBusinessXCustomerId { get; set; }
        public int WmsBusinessId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
