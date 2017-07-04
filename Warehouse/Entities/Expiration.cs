using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Expiration
    {
        public int ExpirationId { get; set; }
        public string Entity { get; set; }
        public int? EntityId { get; set; }
        public int? UserId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reason { get; set; }
    }
}
