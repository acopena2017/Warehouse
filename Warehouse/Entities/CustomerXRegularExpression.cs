using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXRegularExpression
    {
        public int CustomerXRegularExpressionId { get; set; }
        public int? CustomerId { get; set; }
        public string LineExpression { get; set; }
        public string PartExpression { get; set; }
        public string QuantityExpression { get; set; }
        public int? CustomerOrderTypeId { get; set; }
    }
}
