using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerPricelistOutputSettings
    {
        public int SettingId { get; set; }
        public int CustomerId { get; set; }
        public int? CategoryId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
