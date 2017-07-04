using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class LabelType
    {
        public int LabelTypeId { get; set; }
        public string LabelTypeName { get; set; }
        public int LabelsUp { get; set; }
        public int LabelDefaultQty { get; set; }
        public string LabelSize { get; set; }
        public bool Expired { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public int? LabelDisplayHeight { get; set; }
        public int? LabelDisplayWidth { get; set; }
        public bool? ForceLabelPrint { get; set; }
    }
}
