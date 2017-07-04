using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class DboUserXCustomer
    {
        public int UserXCustomerId { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
    }
}
