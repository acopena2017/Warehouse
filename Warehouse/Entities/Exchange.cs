using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Exchange
    {
        public int ExchangeId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public double? Rate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
