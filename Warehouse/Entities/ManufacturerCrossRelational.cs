using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ManufacturerCrossRelational
    {
        public int ManufacturerCrossRelationalId { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public string ManufacturerId { get; set; }
        public string ManufacturerItemId { get; set; }
        public int? FkManufacturerId { get; set; }
        public bool? IsMainCross { get; set; }
    }
}
