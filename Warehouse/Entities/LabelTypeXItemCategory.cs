using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class LabelTypeXItemCategory
    {
        public int LabelTypeXItemCategoryId { get; set; }
        public int? LabelTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
    }
}
