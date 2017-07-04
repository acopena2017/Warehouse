using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXSalesRepresentative
    {
        public int CustomerId { get; set; }
        public int SalesRepresentativeId { get; set; }
        public double? CommissionPercentage { get; set; }
    }
}
