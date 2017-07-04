using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class PriceListOutputRowDefinition
    {
        public int PriceListOutputRowDefinitionId { get; set; }
        public int? ItemCategoryId { get; set; }
        public string PriceListOutputRowDefinition1 { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IncludeApplication { get; set; }
        public string Name { get; set; }
        public string ItemCategoryIdList { get; set; }
        public bool? IsExpired { get; set; }
        public bool? IncludeAllItems { get; set; }
    }
}
