using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class DefectAllowance
    {
        public int DefectAllowanceId { get; set; }
        public int ItemCategoryId { get; set; }
        public string TableName { get; set; }
        public int TableId { get; set; }
        public double? Percent { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
