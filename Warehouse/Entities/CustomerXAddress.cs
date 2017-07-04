using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXAddress
    {
        public int CustomerXAddressId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
