using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public int? CustomerId { get; set; }
        public int? ContactId { get; set; }
        public int? TaskTypeId { get; set; }
        public int? TaskPriorityId { get; set; }
        public int? TaskStatusId { get; set; }
        public string Subject { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? DueDate { get; set; }
        public int? PerformUser { get; set; }
        public DateTime? PerformedDate { get; set; }
        public string Result { get; set; }
    }
}
