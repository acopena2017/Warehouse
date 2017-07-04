using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXMembership
    {
        public int CustomerXMembershipId { get; set; }
        public int MembershipId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
