using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class CustomerLabel
    {
        public int CustomerLabelId { get; set; }
        public int CustomerId { get; set; }
        public int LabelTypeId { get; set; }
        public string LabelFilename { get; set; }
        public int LabelPrinterId { get; set; }
        public bool Expired { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public bool? WmsLabel { get; set; }
    }
}
