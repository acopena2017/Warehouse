using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class TaskPriority
    {
        public int TaskPriorityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Expired { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
    }
}
