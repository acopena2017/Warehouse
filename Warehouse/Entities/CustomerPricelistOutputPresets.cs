using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerPricelistOutputPresets
    {
        public int PresetId { get; set; }
        public string PresetName { get; set; }
        public string PresetDescription { get; set; }
        public bool Expired { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
