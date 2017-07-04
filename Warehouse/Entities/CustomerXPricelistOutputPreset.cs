using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerXPricelistOutputPreset
    {
        public int CustomerXPresetId { get; set; }
        public int? CustomerId { get; set; }
        public int? PresetId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
