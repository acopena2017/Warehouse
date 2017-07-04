using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ShippingCompany
    {
        public int ShippingCompanyId { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Details { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
