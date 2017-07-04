using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class SalesRepresentative
    {
        public int SalesRepresentativeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int? ReportsToId { get; set; }
        public double? DefaultCommission { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public int? UserId { get; set; }
        public int? SalesRepresentativeTypeId { get; set; }
    }
}
