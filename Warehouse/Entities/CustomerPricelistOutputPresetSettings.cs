using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerPricelistOutputPresetSettings
    {
        public int SettingId { get; set; }
        public int PresetId { get; set; }
        public int? CategoryId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
