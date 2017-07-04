using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class SalesPartner
    {
        public int SalesPartnerId { get; set; }
        public int? BusinessId { get; set; }
        public int? PartnerBusinessId { get; set; }
        public int? Rank { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
