using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class ItemPopularityCodes
    {
        public int ItemPopularityCodesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PercentileStart { get; set; }
        public int PercentileEnd { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
