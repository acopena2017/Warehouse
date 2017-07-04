using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class UserPriceListOutputDetail
    {
        public int UserPriceListOutputDetailId { get; set; }
        public int UserPriceListOutputId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool FormChecked { get; set; }
        public bool Sent { get; set; }
        public bool HasEmail { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
