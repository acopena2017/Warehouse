using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ManufacturerPcaousCategory
    {
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }
        public int EBayXreferenceOrder { get; set; }
    }
}
