using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class TaxCodeXTax
    {
        public int TaxCodeId { get; set; }
        public int TaxId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int TaxCodeXTaxId { get; set; }
    }
}
