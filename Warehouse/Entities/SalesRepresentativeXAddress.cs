using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class SalesRepresentativeXAddress
    {
        public int SalesRepresentativeXAddressId { get; set; }
        public int SalesRepresentativeId { get; set; }
        public int AddressId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
